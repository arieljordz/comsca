using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace COMSCA.Models
{
    public class tbl_activeDate
    {
        [Key]
        public int ActiveDateID { get; set; }
        public DateTime ActiveDate { get; set; }
        public bool IsActive { get; set; }
        public int WeekNumber { get; set; }
    }
}
