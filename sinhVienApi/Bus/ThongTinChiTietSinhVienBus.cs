using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sinhVienApi.Entity;
using sinhVienApi.Model;
using sinhVienApi.ViewModel;

namespace sinhVienApi.Bus
{
    public class ThongTinChiTietSinhVienBus
    {
        private readonly apiContext _context;

        public ThongTinChiTietSinhVienBus()
        {

        }

        public ThongTinChiTietSinhVienBus(apiContext context)
        {
            _context = context;
        }
        public List<View_ThongTinChiTietSinhVien> getAll()
        {
            var model = (from SinhVien in _context.SinhVien
                         from Nganh in _context.Nganh
                         from Lop in _context.Lop
                         from Khoa in _context.Khoa

                         where SinhVien.LopHoc_Id == Lop.Lop_Id
                         where Lop.Khoa_Id == Khoa.Khoa_Id
                         where Khoa.Nganh_Id == Nganh.Nganh_Id

                         select new View_ThongTinChiTietSinhVien
                         {
                             SinhVien_Id= SinhVien.SinhVien_Id,
                             GioiTinh= SinhVien.GioiTinh,
                             HoTen = SinhVien.HoTen,
                             NamSinh = SinhVien.NamSinh,
                             DiaChi = SinhVien.DiaChi,
                             Nganh = Nganh.TenNganh,
                             Khoa = Khoa.name,
                             Lop =Lop.name,
                         }).ToList();

            return model;

        }
        public List<View_ThongTinChiTietSinhVien> getById(int id)
        {
            var model = (from SinhVien in _context.SinhVien
                         from Nganh in _context.Nganh
                         from Lop in _context.Lop
                         from Khoa in _context.Khoa

                         where SinhVien.SinhVien_Id == id
                         where SinhVien.LopHoc_Id == Lop.Lop_Id
                         where Lop.Khoa_Id == Khoa.Khoa_Id
                         where Khoa.Nganh_Id == Nganh.Nganh_Id

                         select new View_ThongTinChiTietSinhVien
                         {
                             SinhVien_Id = id,
                             GioiTinh = SinhVien.GioiTinh,
                             HoTen = SinhVien.HoTen,
                             NamSinh = SinhVien.NamSinh,
                             DiaChi = SinhVien.DiaChi,
                             Nganh = Nganh.TenNganh,
                             Khoa = Khoa.name,
                             Lop = Lop.name,
                         }).ToList();

            return model;

        }
    }
}
