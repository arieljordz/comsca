namespace RDLCDesign.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_member
    {
        [Key]
        public int MemberID { get; set; }

        [StringLength(200)]
        public string FirstName { get; set; }

        [StringLength(200)]
        public string LastName { get; set; }

        [StringLength(500)]
        public string FullName { get; set; }

        public int? GenderID { get; set; }

        [StringLength(500)]
        public string Address { get; set; }

        public DateTime? DateRegistered { get; set; }
    }
}
