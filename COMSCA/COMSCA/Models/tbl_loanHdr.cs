using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace COMSCA.Models
{
    public class tbl_loanHdr
    {
        [Key]
        public int LoanHdrID { get; set; }
        public int LoanScheduleID { get; set; }
        public int MemberID { get; set; }
        public int ActiveDateID { get; set; }
        public decimal Amount { get; set; }
    }
}
