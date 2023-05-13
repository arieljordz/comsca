using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COMSCA.DTO
{
    public class WeeksDTO
    {
        public int ActiveDateID { get; set; }
        public string Week { get; set; }
        public string FullName { get; set; }
        public decimal Amount { get; set; }
        public decimal Interest { get; set; }
        public bool IsPaid { get; set; }

    }

}
