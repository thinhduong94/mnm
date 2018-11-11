using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sinhVienApi.Entity;
using sinhVienApi.Model;
using sinhVienApi.ViewModel;

namespace sinhVienApi.Bus
{
    public class khoahocBus
    {
        private readonly apiContext _context;

        public khoahocBus()
        {

        }

        public khoahocBus(apiContext context)
        {
            _context = context;
        }
        public List<khoahocview> getAll()
        {
            //var model = _context.khoahoc.Select(x=>new khoahocview {
            //    id = x.id
            //}).ToList();
            var model = (from kh in _context.khoahoc
                         join ng in _context.Nganh on kh.nganhId equals ng.id
                         select new khoahocview
                         {
                             id = kh.id,
                             name = kh.name,
                             namenganh = ng.name
                         }).ToList();

            return model;

        }
        public bool create(khoahoc item)
        {
            _context.khoahoc.Add(item);
            _context.SaveChanges();
            return true;
        }

        public khoahoc getById(int id)
        {
            var model = _context.khoahoc.Find(id);
            return model;
        }
        public bool edit(int id, khoahoc item)
        {
            try
            {
                var model = _context.khoahoc.Find(id);
                model.name = item.name;
                _context.khoahoc.Update(model);
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
                var model = _context.khoahoc.Find(id);
                _context.khoahoc.Remove(model);
                _context.SaveChanges();
                return true;
            }catch(Exception ex)
            {
                return false;
            }
        }
    }
}
