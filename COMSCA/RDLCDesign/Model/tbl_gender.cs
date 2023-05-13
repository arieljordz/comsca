namespace RDLCDesign.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_gender
    {
        [Key]
        public int GenderID { get; set; }

        [StringLength(50)]
        public string Description { get; set; }
    }
}
