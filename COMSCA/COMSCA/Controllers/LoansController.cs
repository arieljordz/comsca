using COMSCA.DTO;
using COMSCA.Interface;
using COMSCA.Models;
using COMSCA.Models.DBContext;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COMSCA.Controllers
{
    public class LoansController : Controller
    {
        private readonly COMSCADBContext db;
        private readonly InterfaceGlobal global;

        public LoansController(COMSCADBContext context, InterfaceGlobal repository)
        {
            db = context;
            global = repository;
        }

        public IActionResult SearchMember(string FullName)
        {
            try
            {
                var qry = db.tbl_member.Where(x => x.FullName.Contains(FullName)).FirstOrDefault();
                return Json(new { success = true, data = qry });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }

        }

        [HttpPost]
        public IActionResult SaveLoanSchedule(tbl_loanSchedule schedule)
        {
            try
            {
                var qry = db.tbl_loanSchedule.Where(x => x.MemberID == schedule.MemberID).SingleOrDefault();
                if (qry == null)
                {
                    schedule.DateEndcoded = DateTime.Now;
                    schedule.IsApproved = false;
                    schedule.DateSchedule = db.tbl_activeDate.Where(x => x.ActiveDateID == schedule.ActiveDateID).SingleOrDefault().ActiveDate;
                    db.tbl_loanSchedule.Add(schedule);
                    db.SaveChanges();
                }
                else
                {
                    qry.Amount = schedule.Amount;
                    qry.ActiveDateID = schedule.ActiveDateID;
                    qry.DateSchedule = db.tbl_activeDate.Where(x => x.ActiveDateID == schedule.ActiveDateID).SingleOrDefault().ActiveDate;
                    qry.DateEndcoded = DateTime.Now;
                }
                return Json(new { success = true });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }

        public IActionResult GetLoanSchedules(string start)
        {
            //var currMonth = Convert.ToDateTime(starts).AddMonths(1);
            var _start = start == null ? DateTime.Now : Convert.ToDateTime(start);
            var _now = DateTime.Now;

            int days = DateTime.DaysInMonth(_now.Year, _now.Month);
            var Dates = global.GetDates(_start.Year, _start.Month);

            List<object> list = new List<object>();

            foreach (var item in Dates)
            {
                var qry = db.tbl_loanSchedule.Where(x => x.DateSchedule.Day == item.Day && x.DateSchedule.Month == item.Month && x.DateSchedule.Year == item.Year && x.IsApproved == false).ToList();
                if (qry.Count() != 0)
                {
                    foreach (var mem in qry)
                    {
                        list.Add(new
                        {
                            title = db.tbl_member.Where(x => x.MemberID == mem.MemberID).SingleOrDefault().LastName + ", " + db.tbl_member.Where(x => x.MemberID == mem.MemberID).SingleOrDefault().FirstName.Substring(0, 1) + ".",
                            start = item.Year + "-" + item.Month.ToString().PadLeft(2, '0') + "-" + item.Day.ToString().PadLeft(2, '0'),
                            end = item.Year + "-" + item.Month.ToString().PadLeft(2, '0') + "-" + item.Day.ToString().PadLeft(2, '0'),
                        });
                    }
                }
            }
            return Json(new { data = list, count = list.Count() });
        }


        public IActionResult LoadAppliedLoans()
        {
            var list = db.tbl_loanSchedule.Where(x => x.IsApproved == false).ToList();
            List<object> data = new List<object>();
            foreach (var item in list)
            {
                var obj = new
                {
                    LoanScheduleID = item.LoanScheduleID,
                    MemberID = item.MemberID,
                    FullName = db.tbl_member.Where(x => x.MemberID == item.MemberID).SingleOrDefault().FullName,
                    DateSchedule = item.DateSchedule.ToLongDateString(),
                    DateEndcoded = item.DateEndcoded.ToLongDateString(),
                    Amount = Convert.ToDecimal(item.Amount),
                    IsApproved = item.IsApproved,
                };
                data.Add(obj);
            }
            return Json(new { data = data });
        }

        public IActionResult ApprovedDisApproved(int LoanScheduleID, bool isTrue)
        {
            try
            {
                var qry = db.tbl_loanSchedule.Where(x => x.LoanScheduleID == LoanScheduleID).SingleOrDefault();
                if (qry != null)
                {
                    if (isTrue)
                    {
                        qry.IsApproved = true;
                    }
                    else
                    {
                        qry.IsApproved = false;
                    }
                    db.SaveChanges();
                }
                return Json(new { success = true });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }

        public IActionResult LoadApprovedLoans()
        {
            var list = db.tbl_loanSchedule.Where(x => x.IsApproved == true).ToList();
            List<object> data = new List<object>();
            foreach (var item in list)
            {
                var obj = new
                {
                    ApprovedLoanID = item.LoanScheduleID,
                    MemberID = item.MemberID,
                    FullName = db.tbl_member.Where(x => x.MemberID == item.MemberID).SingleOrDefault().FullName,
                    DateSchedule = item.DateSchedule.ToLongDateString(),
                    DateEndcoded = item.DateEndcoded.ToLongDateString(),
                    DateReleased = item.DateReleased == null ? "" : item.DateReleased.Value.ToLongDateString(),
                    Amount = Convert.ToDecimal(item.Amount),
                    IsReleased = item.IsReleased == true ? true : false,
                };
                data.Add(obj);
            }
            return Json(new { data = data });
        }

        public IActionResult ReleasedLoan(int LoanScheduleID, bool isTrue)
        {
            try
            {
                var qry = db.tbl_loanSchedule.Where(x => x.LoanScheduleID == LoanScheduleID && x.IsReleased != true).SingleOrDefault();
                if (qry != null)
                {
                    if (isTrue)
                    {
                        decimal TotalCollection = global.GetTotalCollection();
                        if (TotalCollection > qry.Amount)
                        {
                            DateTime dateNow = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                            var chk = db.tbl_loanSchedule.Where(x => x.LoanScheduleID == LoanScheduleID && x.IsReleased != true && x.DateSchedule == dateNow).Any();

                            if (chk)
                            {
                                qry.IsReleased = true;
                                qry.DateReleased = Convert.ToDateTime(db.tbl_activeDate.Where(x => x.IsActive == true).SingleOrDefault().ActiveDate);
                                qry.ActiveDateID = db.tbl_activeDate.Where(x => x.IsActive == true).SingleOrDefault().ActiveDateID;
                                db.SaveChanges();

                                SaveLoanHdr(LoanScheduleID);

                                return Json(new { success = true });
                            }
                            else
                            {
                                DateTime DateSchedule = new DateTime(qry.DateSchedule.Year, qry.DateSchedule.Month, qry.DateSchedule.Day);
                                return Json(new { success = false, message = "This loan application should be released on " + DateSchedule.ToString("MMMM dd, yyyy") + "." });
                            }

                        }
                        else
                        {
                            return Json(new { success = false, message = "The Total Amount of Collection is not enough for this loan applied." });
                        }
                    }
                    else
                    {
                        qry.IsApproved = false;
                        db.SaveChanges();
                        return Json(new { success = true });
                    }
                }
                else
                {
                    return Json(new { success = false, message = "This Loan application is already released." });
                }
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }

        public void SaveLoanHdr(int LoanScheduleID)
        {
            tbl_loanHdr loanHdr = new tbl_loanHdr();
            loanHdr.LoanScheduleID = LoanScheduleID;
            loanHdr.MemberID = db.tbl_loanSchedule.Where(x => x.LoanScheduleID == LoanScheduleID).SingleOrDefault().MemberID;
            loanHdr.ActiveDateID = db.tbl_loanSchedule.Where(x => x.LoanScheduleID == LoanScheduleID).SingleOrDefault().ActiveDateID;
            loanHdr.Amount = db.tbl_loanSchedule.Where(x => x.LoanScheduleID == LoanScheduleID).SingleOrDefault().Amount;
            db.tbl_loanHdr.Add(loanHdr);
            db.SaveChanges();
        }

        public IActionResult LoadMembersLoan()
        {
            var list = db.tbl_loanSchedule.Where(x => x.IsApproved == true && x.IsReleased == true).ToList();
            List<object> data = new List<object>();
            foreach (var item in list)
            {
                var obj = new
                {
                    LoanScheduleID = item.LoanScheduleID,
                    MemberID = item.MemberID,
                    FullName = db.tbl_member.Where(x => x.MemberID == item.MemberID).SingleOrDefault().FullName,
                    DateReleased = item.DateReleased == null ? "" : item.DateReleased.Value.ToLongDateString(),
                    DateEndcoded = item.DateEndcoded.ToLongDateString(),
                    Amount = Convert.ToDecimal(item.Amount),
                };
                data.Add(obj);
            }
            return Json(new { data = data });
        }

        public IActionResult GetCollection()
        {
            CollectionDTO obj = new CollectionDTO();
            obj.TotalCollection = global.GetTotalCollection();
            obj.TotalLoans = global.GetTotalLoans();
            obj.TotalAbsentFees = global.GetTotalAbsentFees();
            obj.TotalInterest = global.GetTotalInterest();
            obj.CurrentCollection = global.GetCurrentCollection();
            return Json(new { data = obj });
        }








    }
}
