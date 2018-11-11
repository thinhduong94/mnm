using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sinhVienApi.Entity;
using sinhVienApi.Model;

namespace sinhVienApi.Bus
{
    public class NganhBus
    {
        private readonly apiContext _context;

        public NganhBus()
        {

        }

        public NganhBus(apiContext context)
        {
            _context = context;
        }
        public List<Nganh> getAll()
        {
            var model = _context.Nganh.ToList();

            return model;

        }
        public bool create(Nganh nganh)
        {
            _context.Nganh.Add(nganh);
            _context.SaveChanges();
            return true;
        }

        public Nganh getById(int id)
        {
            var model = _context.Nganh.Find(id);
            return model;
        }
        public bool edit(int id, Nganh nganh)
        {
            try
            {
                var model = _context.Nganh.Find(id);
                model.name = nganh.name;
                _context.Nganh.Update(model);
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
                var model = _context.Nganh.Find(id);
                _context.Nganh.Remove(model);
                _context.SaveChanges();
                return true;
            }catch(Exception ex)
            {
                return false;
            }
        }
    }
}
