using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace COMSCA.Models
{
    public class tbl_collectionDtls
    {
        [Key]
        public int CollectionDtlsID { get; set; }
        public int CollectionID { get; set; }
        public int MemberID { get; set; }
        public int ActiveDateID { get; set; }
        public decimal AmountofWeek { get; set; }
        public decimal AmountofWeekAbsent { get; set; }
        public decimal TotalAmountPaid { get; set; }
        public bool IsPaid { get; set; }
    }
}
