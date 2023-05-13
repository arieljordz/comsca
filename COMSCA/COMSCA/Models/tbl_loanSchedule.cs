using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace COMSCA.Models
{
    public class tbl_loanSchedule
    {
        [Key]
        public int LoanScheduleID { get; set; }
        public int MemberID { get; set; }
        public DateTime DateSchedule { get; set; }
        public decimal Amount { get; set; }
        public DateTime DateEndcoded { get; set; }
        public bool? IsApproved { get; set; }
        public bool? IsReleased { get; set; }
        public DateTime? DateReleased { get; set; }
        public int ActiveDateID { get; set; }
    }
}
