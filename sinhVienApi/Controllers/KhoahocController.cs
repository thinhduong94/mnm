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
    [Route("api/Khoahoc")]
    [ApiController]
    public class KhoahocController : ControllerBase
    {
        private readonly khoahocBus itemBus;
        private readonly apiContext _context;
        public KhoahocController(apiContext context)
        {
            _context = context;
            itemBus = new khoahocBus(_context);
        }
        // GET api/values
        [HttpGet,Route("")]
        public ActionResult Get()
        {
            return Ok(new { data = itemBus.getAll() });
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(new { data = itemBus.getById(id) });
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post(khoahoc item)
        {
            var rp = itemBus.create(item);
            return Ok(new { data = rp });
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, khoahoc item)
        {
            return Ok(new { data = itemBus.edit(id, item) });
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(new { data = itemBus.delete(id) });
        }
    }
}
