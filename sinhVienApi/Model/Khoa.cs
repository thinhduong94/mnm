using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sinhVienApi.Model
{
    public class Khoa
    {
        [Key]
        public int Khoa_Id { get; set; }
        public string name { get; set; }
        public int Nganh_Id { get; set; }

    }
}
