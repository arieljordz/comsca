using COMSCA.DTO;
using COMSCA.Interface;
using COMSCA.Models;
using COMSCA.Models.DBContext;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace COMSCA.Controllers
{
    public class CollectionController : Controller
    {
        private readonly COMSCADBContext db;
        private readonly InterfaceGlobal global;

        public CollectionController(COMSCADBContext context, InterfaceGlobal repository)
        {
            db = context;
            global = repository;
        }

        [HttpPost]
        public IActionResult SaveContribution(tbl_collection collection)
        {
            try
            {
                collection.DatePaid = Convert.ToDateTime(db.tbl_activeDate.Where(x => x.IsActive == true).SingleOrDefault().ActiveDate);
                var qry = db.tbl_collection.Where(x => x.MemberID == collection.MemberID && x.DatePaid.Date == collection.DatePaid.Date).SingleOrDefault();
                if (qry != null)
                {
                    qry.AmountPaid = collection.AmountPaid;
                    qry.NoofWeeks = collection.NoofWeeks;
                    qry.NoofWeeksAbsent = collection.NoofWeeksAbsent;
                    qry.MemberID = collection.MemberID;
                    db.SaveChanges();

                    var ledger = db.tbl_collectionDtls.Where(x => x.CollectionID == qry.CollectionID).ToList();
                    if (ledger.Count() != 0)
                    {
                        db.tbl_collectionDtls.RemoveRange();
                        db.SaveChanges();
                    }

                    SaveCollectionLedger(qry.NoofWeeks, qry.CollectionID, qry.NoofWeeksAbsent, collection.MemberID);
                }
                else
                {
                    collection.DatePaid = collection.DatePaid;
                    collection.MemberID = collection.MemberID;
                    collection.UserID = 1;
                    db.tbl_collection.Add(collection);
                    db.SaveChanges();

                    SaveCollectionLedger(collection.NoofWeeks, collection.CollectionID, collection.NoofWeeksAbsent, collection.MemberID);
                }
                return Json(new { success = true });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }

        }

        public void SaveCollectionLedger(int NoofWeeks, int CollectionID, int NoofWeeksAbsent, int MemberID)
        {
            DateTime DateofWeek = Convert.ToDateTime(db.tbl_activeDate.Where(x => x.IsActive == true).SingleOrDefault().ActiveDate);
            DateTime DateofWeekAbsent = Convert.ToDateTime(db.tbl_activeDate.Where(x => x.IsActive == true).SingleOrDefault().ActiveDate);
            int ActiveDateID = db.tbl_activeDate.Where(x => x.IsActive == true).SingleOrDefault().ActiveDateID;

            //int CountWeeksAbsent = NoofWeeks - NoofWeeksAbsent;

            int loopCount = 1;

            for (int i = 0; i < NoofWeeks; i++)
            {
                var dtls = db.tbl_collectionDtls.Where(x => x.MemberID == MemberID && x.ActiveDateID == ActiveDateID).SingleOrDefault();
                if (dtls != null)
                {
                    dtls.CollectionID = CollectionID;
                    dtls.AmountofWeek = db.tbl_feeDtls.Where(x => x.IsActive == true && x.Description == "Contribution Fee").SingleOrDefault().Amount;
                    dtls.IsPaid = true;
                    dtls.AmountofWeekAbsent = AbsentFee(NoofWeeksAbsent, loopCount);
                    dtls.TotalAmountPaid = dtls.AmountofWeek + dtls.AmountofWeekAbsent;
                    db.SaveChanges();

                    var has_loan = db.tbl_loanHdr.Where(x => x.MemberID == MemberID).Any();
                    if (has_loan)
                    {
                        decimal percent = db.tbl_feeDtls.Where(x => x.IsActive == true && x.Description == "Service Charge Fee").SingleOrDefault().Amount;
                        decimal Amount = db.tbl_loanHdr.Where(x => x.MemberID == MemberID).SingleOrDefault().Amount;
                        tbl_loanDtls loanDtls = new tbl_loanDtls();
                        loanDtls.LoandHdrID = db.tbl_loanHdr.Where(x => x.MemberID == MemberID).SingleOrDefault().LoanHdrID;
                        loanDtls.DatePaid = db.tbl_activeDate.Where(x => x.ActiveDateID == ActiveDateID).SingleOrDefault().ActiveDate;
                        loanDtls.Amount = Amount * percent;
                        loanDtls.IsPaid = true;
                        db.tbl_loanDtls.Add(loanDtls);
                        db.SaveChanges();
                    }

                    DateofWeek = DateofWeek.AddDays(7);
                    DateofWeekAbsent = DateofWeekAbsent.AddDays(7);
                    ActiveDateID = db.tbl_activeDate.Where(x => x.ActiveDate.Date == DateofWeek.Date).SingleOrDefault().ActiveDateID;
                    loopCount++;
                }
            }
        }

        public decimal AbsentFee(int NoofWeeksAbsent, int loopCount)
        {
            decimal Fee = 0.0M;
            decimal AbsentFee = db.tbl_feeDtls.Where(x => x.IsActive == true && x.Description == "Absent Fee").SingleOrDefault().Amount;
            if (NoofWeeksAbsent != 0)
            {
                Fee = NoofWeeksAbsent >= loopCount ? 0 : AbsentFee;
            }
            return Fee;
        }

        public IActionResult LoadLedger()
        {
            var query = from a in db.tbl_collectionDtls.ToList()
                        group a by a.MemberID into g
                        select new
                        {
                            MemberID = g.Key,
                            ActiveDateIDs = string.Join(",", g.Select(x =>x.ActiveDateID))
                        };

            var query2 = (from a in query
                          join b in db.tbl_member on a.MemberID equals b.MemberID
                          select new LedgerDtlsDTO
                          {
                              MemberID = b.MemberID,
                              FullName = b.FullName,
                              ActiveDateIDs = a.ActiveDateIDs
                          });

            List<LedgersDTO> data = new List<LedgersDTO>();
            int count = 1;
            foreach (var item in query2)
            {
                //string[] arr_DateIDs = item.ActiveDateIDs.Split(new char[] { ',' });
                var collectionDtls = (from a in db.tbl_collectionDtls join b in db.tbl_activeDate on a.ActiveDateID equals b.ActiveDateID where a.MemberID == item.MemberID select new { a, b }).ToList();
                var TotalAmount = global.MoneyFormat(db.tbl_collectionDtls.Where(x => x.MemberID == item.MemberID).Sum(x => x.AmountofWeek));
                var obj = new LedgersDTO
                {
                    //LedgerID = count,
                    //MemberID = item.MemberID,
                    //TotalString = Convert.ToDecimal(TotalAmount).ToString("N2"),
                    //WeekDate = collectionDtls.Where(x => x.a.MemberID == item.MemberID).Select(x => x.b.ActiveDate.ToShortDateString()).ToList(),

                    FullName = item.FullName,
                    Week1 = collectionDtls.Where(x => x.b.WeekNumber == 1).SingleOrDefault().a.IsPaid,
                    Week2 = collectionDtls.Where(x => x.b.WeekNumber == 2).SingleOrDefault().a.IsPaid,
                    Week3 = collectionDtls.Where(x => x.b.WeekNumber == 3).SingleOrDefault().a.IsPaid,
                    Week4 = collectionDtls.Where(x => x.b.WeekNumber == 4).SingleOrDefault().a.IsPaid,
                    Week5 = collectionDtls.Where(x => x.b.WeekNumber == 5).SingleOrDefault().a.IsPaid,
                    Week6 = collectionDtls.Where(x => x.b.WeekNumber == 6).SingleOrDefault().a.IsPaid,
                    Week7 = collectionDtls.Where(x => x.b.WeekNumber == 7).SingleOrDefault().a.IsPaid,
                    Week8 = collectionDtls.Where(x => x.b.WeekNumber == 8).SingleOrDefault().a.IsPaid,
                    Week9 = collectionDtls.Where(x => x.b.WeekNumber == 9).SingleOrDefault().a.IsPaid,
                    Week10 = collectionDtls.Where(x => x.b.WeekNumber == 10).SingleOrDefault().a.IsPaid,
                    Week11 = collectionDtls.Where(x => x.b.WeekNumber == 11).SingleOrDefault().a.IsPaid,
                    Week12 = collectionDtls.Where(x => x.b.WeekNumber == 12).SingleOrDefault().a.IsPaid,
                    Week13 = collectionDtls.Where(x => x.b.WeekNumber == 13).SingleOrDefault().a.IsPaid,
                    Week14 = collectionDtls.Where(x => x.b.WeekNumber == 14).SingleOrDefault().a.IsPaid,
                    Week15 = collectionDtls.Where(x => x.b.WeekNumber == 15).SingleOrDefault().a.IsPaid,
                    Week16 = collectionDtls.Where(x => x.b.WeekNumber == 16).SingleOrDefault().a.IsPaid,
                    Week17 = collectionDtls.Where(x => x.b.WeekNumber == 17).SingleOrDefault().a.IsPaid,
                    Week18 = collectionDtls.Where(x => x.b.WeekNumber == 18).SingleOrDefault().a.IsPaid,
                    Week19 = collectionDtls.Where(x => x.b.WeekNumber == 19).SingleOrDefault().a.IsPaid,
                    Week20 = collectionDtls.Where(x => x.b.WeekNumber == 20).SingleOrDefault().a.IsPaid,
                    Week21 = collectionDtls.Where(x => x.b.WeekNumber == 21).SingleOrDefault().a.IsPaid,
                    Week22 = collectionDtls.Where(x => x.b.WeekNumber == 22).SingleOrDefault().a.IsPaid,
                    Week23 = collectionDtls.Where(x => x.b.WeekNumber == 23).SingleOrDefault().a.IsPaid,
                    Week24 = collectionDtls.Where(x => x.b.WeekNumber == 24).SingleOrDefault().a.IsPaid,
                    Week25 = collectionDtls.Where(x => x.b.WeekNumber == 25).SingleOrDefault().a.IsPaid,
                    Week26 = collectionDtls.Where(x => x.b.WeekNumber == 26).SingleOrDefault().a.IsPaid,
                    Week27 = collectionDtls.Where(x => x.b.WeekNumber == 27).SingleOrDefault().a.IsPaid,
                    Week28 = collectionDtls.Where(x => x.b.WeekNumber == 28).SingleOrDefault().a.IsPaid,
                    Week29 = collectionDtls.Where(x => x.b.WeekNumber == 29).SingleOrDefault().a.IsPaid,
                    Week30 = collectionDtls.Where(x => x.b.WeekNumber == 30).SingleOrDefault().a.IsPaid,
                    Week31 = collectionDtls.Where(x => x.b.WeekNumber == 31).SingleOrDefault().a.IsPaid,
                    Week32 = collectionDtls.Where(x => x.b.WeekNumber == 32).SingleOrDefault().a.IsPaid,
                    Week33 = collectionDtls.Where(x => x.b.WeekNumber == 33).SingleOrDefault().a.IsPaid,
                    Week34 = collectionDtls.Where(x => x.b.WeekNumber == 34).SingleOrDefault().a.IsPaid,
                    Week35 = collectionDtls.Where(x => x.b.WeekNumber == 35).SingleOrDefault().a.IsPaid,
                    Week36 = collectionDtls.Where(x => x.b.WeekNumber == 36).SingleOrDefault().a.IsPaid,
                    Week37 = collectionDtls.Where(x => x.b.WeekNumber == 37).SingleOrDefault().a.IsPaid,
                    Week38 = collectionDtls.Where(x => x.b.WeekNumber == 38).SingleOrDefault().a.IsPaid,
                    Week39 = collectionDtls.Where(x => x.b.WeekNumber == 39).SingleOrDefault().a.IsPaid,
                    Week40 = collectionDtls.Where(x => x.b.WeekNumber == 40).SingleOrDefault().a.IsPaid,
                    Week41 = collectionDtls.Where(x => x.b.WeekNumber == 41).SingleOrDefault().a.IsPaid,
                    Week42 = collectionDtls.Where(x => x.b.WeekNumber == 42).SingleOrDefault().a.IsPaid,
                    Week43 = collectionDtls.Where(x => x.b.WeekNumber == 43).SingleOrDefault().a.IsPaid,
                    Week44 = collectionDtls.Where(x => x.b.WeekNumber == 44).SingleOrDefault().a.IsPaid,
                    Week45 = collectionDtls.Where(x => x.b.WeekNumber == 45).SingleOrDefault().a.IsPaid,
                    Week46 = collectionDtls.Where(x => x.b.WeekNumber == 46).SingleOrDefault().a.IsPaid,
                    Week47 = collectionDtls.Where(x => x.b.WeekNumber == 47).SingleOrDefault().a.IsPaid,
                    Week48 = collectionDtls.Where(x => x.b.WeekNumber == 48).SingleOrDefault().a.IsPaid,
                    Week49 = collectionDtls.Where(x => x.b.WeekNumber == 49).SingleOrDefault().a.IsPaid,
                    Week50 = collectionDtls.Where(x => x.b.WeekNumber == 50).SingleOrDefault().a.IsPaid,
                    Week51 = collectionDtls.Where(x => x.b.WeekNumber == 51).SingleOrDefault().a.IsPaid,
                    Total = "₱ " + TotalAmount,
                };
                data.Add(obj);
                count++;
            }
            return Json(new
            {
                data = data
            });
        }

        public IActionResult GetCurrentLoan(int MemberID)
        {
            try
            {
                CurrentLoanDTO obj = new CurrentLoanDTO();
                decimal interest = db.tbl_feeDtls.Where(x => x.Description == "Service Charge Fee" && x.IsActive == true).SingleOrDefault().Amount;
                var qry = db.tbl_loanSchedule.Where(x => x.MemberID == MemberID && x.IsReleased == true).ToList();
                if (qry != null)
                {
                    obj.CurrentLoan = qry.Sum(x => x.Amount);
                    obj.ServiceCharge = obj.CurrentLoan * interest;
                }
                return Json(new { data = obj });
            }
            catch (Exception ex)
            {
                return Json(new { message = ex.Message });
            }
        }


    }

}

