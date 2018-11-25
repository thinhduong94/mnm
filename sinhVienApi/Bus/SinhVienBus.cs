using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sinhVienApi.Entity;
using sinhVienApi.Model;

namespace sinhVienApi.Bus
{
    public class SinhVienBus
    {
        private readonly apiContext _context;

        public SinhVienBus()
        {

        }

        public SinhVienBus(apiContext context)
        {
            _context = context;
        }
        public List<SinhVien> getAll()
        {
            var model = _context.SinhVien.ToList();

            return model;

        }
        public bool create(SinhVien sinhvien)
        {
            _context.SinhVien.Add(sinhvien);
            _context.SaveChanges();
            return true;
        }

        public SinhVien getById(int id)
        {
            var model = _context.SinhVien.Find(id);
            return model;
        }
        public bool edit(int id, SinhVien sinhvien)
        {
            try
            {
                var model = _context.SinhVien.Find(id);               
                model.GioiTinh = sinhvien.GioiTinh;
                model.HoTen = sinhvien.HoTen;
                model.NamSinh = sinhvien.NamSinh;
                model.DiaChi = sinhvien.DiaChi;
                model.LopHoc_Id = sinhvien.LopHoc_Id;
                _context.SinhVien.Update(model);
                _context.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
        public bool delete(int id)
        {
            try
            {
                var model = _context.SinhVien.Find(id);
                _context.SinhVien.Remove(model);
                _context.SaveChanges();
                return true;
            }catch(Exception ex)
            {
                return false;
            }
        }
    }
}
