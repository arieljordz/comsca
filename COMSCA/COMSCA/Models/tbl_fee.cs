using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace COMSCA.Models
{
    public class tbl_fee
    {
        [Key]
        public int FeeID { get; set; }
        public string Description { get; set; }
    }
}
