using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sinhVienApi.Model
{
    public class SinhVien
    {
        [Key]
        public int SinhVien_Id { get; set; }
        public string GioiTinh { get; set; }
        public string HoTen { get; set; }
        public string NamSinh { get; set; }
        public string DiaChi { get; set; }
        public int LopHoc_Id { get; set; }
    }
}
