using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sinhVienApi.Model
{
    public class MonHoc
    {
        [Key]
        public int MonHoc_Id { get; set; }
        public string TenMon { get; set; }
        public string MoTa { get; set; }
    }
}
