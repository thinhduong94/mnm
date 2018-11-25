using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sinhVienApi.Bus;
using sinhVienApi.Entity;
using sinhVienApi.Model;

namespace sinhVienApi.Controllers
{
    [Route("api/SinhVien")]
    [ApiController]
    public class SinhVienController : ControllerBase
    {
        private readonly SinhVienBus _SinhVienBus;
        private readonly apiContext _context;
        public SinhVienController(apiContext context)
        {
            _context = context;
            _SinhVienBus = new SinhVienBus(_context);
        }
        // GET api/values
        [HttpGet,Route("")]
        public ActionResult Get()
        {
            return Ok(new { data = _SinhVienBus.getAll() });
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(new { data = _SinhVienBus.getById(id) });
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post(SinhVien sinhVien)
        {
            var rp = _SinhVienBus.create(sinhVien);
            return Ok(new { data = rp });
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, SinhVien sinhVien)
        {
            return Ok(new { data = _SinhVienBus.edit(id, sinhVien) });
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(new { data = _SinhVienBus.delete(id) });
        }
    }
}
