using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sinhVienApi.ViewModel
{
    public class View_DangKyMonHoc
    {
        public int SinhVien_Id { get; set; }
        public int HocKy_Id { get; set; }
        public List<int> MonHocList { get; set; }
    }
}
