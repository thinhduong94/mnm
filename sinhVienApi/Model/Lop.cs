using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sinhVienApi.Model
{
    public class Lop
    {
        [Key]
        public int Lop_Id { get; set; }
        public string name { get; set; }
        public int Khoa_Id { get; set; }
    }
}
