﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace COMSCA.Models
{
    public class tbl_gender
    {
        [Key]
        public int GenderID { get; set; }
        public string Description { get; set; }
    }
}
