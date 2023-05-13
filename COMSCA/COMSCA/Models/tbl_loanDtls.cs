using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace COMSCA.Models
{
    public class tbl_loanDtls
    {
        [Key]
        public int LoanDtlsID { get; set; }
        public int LoandHdrID { get; set; }
        public bool IsPaid { get; set; }
        public DateTime DatePaid { get; set; }
        public decimal Amount { get; set; }
    }
}
