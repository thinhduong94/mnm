﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sinhVienApi.Model
{
    public class Nganh
    {
        [Key]
        public int Nganh_Id { get; set; }
        public string TenNganh { get; set; }
    }
}
