using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COMSCA.DTO
{
    public class LoanLedgerDTO
    {
        public int LoanScheduleID { get; set; }
        public string FullName { get; set; }
        public decimal Amount { get; set; }
        public List<string> Weeks { get; set; }
    }

}
