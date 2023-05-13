namespace RDLCDesign.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_collection
    {
        [Key]
        public int CollectionID { get; set; }

        public int? UserID { get; set; }

        public int? MemberID { get; set; }

        public DateTime? DatePaid { get; set; }

        public decimal? AmountPaid { get; set; }

        public int? NoofWeeks { get; set; }

        public int? NoofWeeksAbsent { get; set; }

        [StringLength(50)]
        public string ORNumber { get; set; }
    }
}
