using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COMSCA.DTO
{
    public class CollectionDTO
    {
        public decimal TotalCollection { get; set; }
        public decimal TotalLoans { get; set; }
        public decimal TotalAbsentFees { get; set; }
        public decimal TotalInterest { get; set; }
        public decimal CurrentCollection { get; set; }

    }

}
