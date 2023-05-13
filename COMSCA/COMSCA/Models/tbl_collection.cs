using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace COMSCA.Models
{
    public class tbl_collection
    {
        [Key]
        public int CollectionID { get; set; }
        public int UserID { get; set; }
        public int MemberID { get; set; }
        public DateTime DatePaid { get; set; }
        public decimal AmountPaid { get; set; }
        public int NoofWeeks { get; set; }
        public int NoofWeeksAbsent { get; set; }
        public string ORNumber { get; set; }
    }
}
