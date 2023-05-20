using COMSCA.Controllers;
using COMSCA.DTO;
using COMSCA.Interface;
using COMSCA.Models;
using COMSCA.Models.DBContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace COMSCA.Repository
{
    public class GlobalRepository : InterfaceGlobal
    {
        private readonly COMSCADBContext db;

        public GlobalRepository(COMSCADBContext context)
        {
            db = context;
        }

        public int GetWeeksInYear(DateTime StartDate)
        {
            DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
            Calendar cal = dfi.Calendar;
            return cal.GetWeekOfYear(StartDate, dfi.CalendarWeekRule, dfi.FirstDayOfWeek);
        }

        public List<DateTime> GetDates(int year, int month)
        {
            var dates = new List<DateTime>();

            // Loop from the first day of the month until we hit the next month, moving forward a day at a time
            for (var date = new DateTime(year, month, 1); date.Month == month; date = date.AddDays(1))
            {
                dates.Add(date);
            }
            return dates;
        }

        public List<LoanLedgerDTO> GetLoanLedger(int LoanScheduleID)
        {
            var loans = db.tbl_loanSchedule.Where(x => x.IsReleased == true && x.LoanScheduleID == LoanScheduleID).ToList();

            var active_date_id = db.tbl_activeDate.Where(x => x.IsActive == true).SingleOrDefault().ActiveDateID;
            List<LoanLedgerDTO> list = new List<LoanLedgerDTO>();
            foreach (var item in loans)
            {
                var obj = new LoanLedgerDTO
                {
                    LoanScheduleID = item.LoanScheduleID,
                    FullName = db.tbl_member.Where(x => x.MemberID == item.MemberID).SingleOrDefault().FullName,
                    Amount = item.Amount,
                    Weeks = db.tbl_activeDate.Where(x => x.ActiveDateID >= item.ActiveDateID && x.ActiveDateID <= active_date_id).Select(x => x.ActiveDate.ToShortDateString()).ToList(),
                };
                list.Add(obj);
            }
            return list;
        }

        public decimal GetTotalCollection()
        {
            decimal TotalAmount = 0.00M;
            var qry = db.tbl_collection.Any();
            if (qry)
            {
                TotalAmount = db.tbl_collection.Sum(x => x.AmountPaid);
            }
            return TotalAmount;
        }

        public decimal GetTotalLoans()
        {
            decimal TotalAmount = 0.00M;
            var loans = db.tbl_loanSchedule.Where(x => x.IsReleased == true).Any();
            if (loans)
            {
                TotalAmount = loans == true ? db.tbl_loanSchedule.Where(x => x.IsReleased == true).Sum(x => x.Amount) : 0.00M;
            }
            return TotalAmount;
        }

        public decimal GetTotalAbsentFees()
        {
            decimal TotalAmount = 0.00M;
            var qry = db.tbl_collection.Any();
            if (qry)
            {
                decimal WeeksAbsent = db.tbl_collection.Sum(x => x.NoofWeeksAbsent);
                decimal AbsentFee = db.tbl_feeDtls.Where(x => x.IsActive == true && x.Description == "Absent Fee").SingleOrDefault().Amount;
                TotalAmount = WeeksAbsent * AbsentFee;
            }
            return TotalAmount;
        }

        public decimal GetTotalInterest()
        {
            decimal TotalAmount = 0.00M;
            var qry = db.tbl_loanDtls.Any();
            if (qry)
            {
                decimal CountPaid = db.tbl_loanDtls.Where(x => x.IsPaid == true).Count();
                decimal ServiceChargeFee = db.tbl_feeDtls.Where(x => x.IsActive == true && x.Description == "Service Charge Fee").SingleOrDefault().Amount;
                TotalAmount = CountPaid * ServiceChargeFee;
            }
            return TotalAmount;
        }

        public decimal GetCurrentCollection()
        {
            decimal TotalAmount = 0.00M;
            decimal TotalCollection = GetTotalCollection();
            decimal TotalLoans = GetTotalLoans();
            decimal TotalAbsentFees = GetTotalAbsentFees();
            decimal TotalInterest = GetTotalInterest();
            TotalAmount = (((TotalCollection - TotalLoans) - TotalAbsentFees) - TotalInterest);
            return TotalAmount;
        }

        public string MoneyFormat(decimal? Amount)
        {
            return Amount == null ? "0.00".Substring(1) : string.Format("{0:C}", Amount).Substring(1);
        }

        public List<ActiveDateDTO> GetLoanDates()
        {
            List<ActiveDateDTO> date_list = new List<ActiveDateDTO>();

            var chk = db.tbl_activeDate.Where(x => x.IsActive == true).SingleOrDefault();
            if (chk != null)
            {
                int WeekNumber = db.tbl_activeDate.Where(x => x.IsActive == true).SingleOrDefault().WeekNumber;
                var qry = db.tbl_activeDate.Where(x => x.WeekNumber >= WeekNumber).ToList();
                foreach (var item in qry)
                {
                    var obj = new ActiveDateDTO
                    {
                        ActiveDateID = item.ActiveDateID,
                        ActiveDate = item.ActiveDate.ToLongDateString(),
                    };
                    date_list.Add(obj);
                }
            }
            return date_list;
        }

    }
}
