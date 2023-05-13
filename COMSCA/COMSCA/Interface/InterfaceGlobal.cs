using COMSCA.DTO;
using COMSCA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COMSCA.Interface
{
    public interface InterfaceGlobal
    {
        int GetWeeksInYear(DateTime StartDate);
        List<DateTime> GetDates(int year, int month);
        List<LoanLedgerDTO> GetLoanLedger(int LoanScheduleID);
        decimal GetTotalCollection();
        decimal GetTotalLoans();
        decimal GetTotalAbsentFees();
        decimal GetTotalInterest();
        decimal GetCurrentCollection();
        string MoneyFormat(decimal? Amount);
        List<ActiveDateDTO> GetLoanDates();
    }
}
