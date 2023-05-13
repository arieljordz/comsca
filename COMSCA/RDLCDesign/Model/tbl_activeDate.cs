namespace RDLCDesign.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_activeDate
    {
        [Key]
        public int ActiveDateID { get; set; }

        public DateTime? ActiveDate { get; set; }

        public bool? IsActive { get; set; }

        public int? WeekNumber { get; set; }
    }
}
