using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sinhVienApi.Model
{
    public class ChiTietHocKy
    {
        [Key]
        public int HocKy_Id { get; set; }
        public int MonHoc_Id { get; set; }
        public int Diem { get; set; }
    }
}
