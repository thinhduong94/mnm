using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sinhVienApi.Model
{
    public class NamHoc
    {
        [Key]
        public int NamHoc_Id { get; set; }
        public string name { get; set; }
        public int SinhVien_Id { get; set; }
    }
}
