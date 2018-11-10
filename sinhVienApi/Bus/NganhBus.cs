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
    }
}
