using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sinhVienApi.Entity;
using sinhVienApi.Model;
using sinhVienApi.ViewModel;

namespace sinhVienApi.Bus
{
    public class DangKyMonHocBus
    {
        private readonly apiContext _context;

        public DangKyMonHocBus()
        {

        }

        public DangKyMonHocBus(apiContext context)
        {
            _context = context;
        }
        public bool create(ChiTietHocKy chiTietHocKy)
        {
            _context.ChiTietHocKy.Add(chiTietHocKy);
            _context.SaveChanges();
            return true;
        }
        public bool edit(int MonHoc_id, int HocKy_id, ChiTietHocKy chiTietHocKy)
        {
            try
            {
                var model = _context.ChiTietHocKy.Find(MonHoc_id,HocKy_id);
                model.Diem = chiTietHocKy.Diem;
                _context.ChiTietHocKy.Update(model);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool delete(int MonHoc_id, int HocKy_id, ChiTietHocKy chiTietHocKy)
        {
            try
            {
                var model = _context.ChiTietHocKy.Find(MonHoc_id, HocKy_id);
                _context.ChiTietHocKy.Remove(model);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public List<View_DangKyMonHoc> getAll()
        {
            var model = (from SinhVien in _context.SinhVien
                         from NamHoc in _context.NamHoc
                         from HocKy in _context.HocKy
                         from ChiTietHocKy in _context.ChiTietHocKy
                         from MonHoc in _context.MonHoc
                         

                         where SinhVien.SinhVien_Id == NamHoc.SinhVien_Id
                         where NamHoc.NamHoc_Id == HocKy.HocKy_Id
                         where HocKy.HocKy_Id == ChiTietHocKy.HocKy_Id
                         where MonHoc.MonHoc_Id == ChiTietHocKy.MonHoc_Id   

                         select new View_DangKyMonHoc
                         {
                             SinhVien_Id= SinhVien.SinhVien_Id,
                             HocKy_Id = HocKy.HocKy_Id,
                         }).ToList();

            return model;

        }
        public List<View_DangKyMonHoc> getById(int id)
        {
            var model = (from SinhVien in _context.SinhVien
                         from NamHoc in _context.NamHoc
                         from HocKy in _context.HocKy
                         from ChiTietHocKy in _context.ChiTietHocKy
                         from MonHoc in _context.MonHoc

                         where SinhVien.SinhVien_Id == id
                         where SinhVien.SinhVien_Id == NamHoc.SinhVien_Id
                         where NamHoc.NamHoc_Id == HocKy.HocKy_Id
                         where HocKy.HocKy_Id == ChiTietHocKy.HocKy_Id
                         where MonHoc.MonHoc_Id == ChiTietHocKy.MonHoc_Id

                         select new View_DangKyMonHoc
                         {
                             SinhVien_Id = SinhVien.SinhVien_Id,
                             HocKy_Id = HocKy.HocKy_Id,
                         }).ToList();

            return model;
        }
    }
}
