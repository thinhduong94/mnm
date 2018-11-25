using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sinhVienApi.Model
{
    public class HocKy
    {
        [Key]
        public int HocKy_Id { get; set; }
        public string name { get; set; }
        public int NamHoc_Id { get; set; }
    }
}
