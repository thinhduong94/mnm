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
    [Route("api/DangKyMonHoc")]
    [ApiController]
    public class DangKyMonHocController : ControllerBase
    {
        private readonly DangKyMonHocBus _DangKyMonHocBus;
        private readonly apiContext _context;
        public DangKyMonHocController(apiContext context)
        {
            _context = context;
            _DangKyMonHocBus = new DangKyMonHocBus(_context);
        }
        // GET api/values
        [HttpGet,Route("")]
        public ActionResult Get()
        {
            return Ok(new { data = _DangKyMonHocBus.getAll() });
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(new { data = _DangKyMonHocBus.getById(id) });
        }
        // POST api/values
        [HttpPost]
        public ActionResult Post(ChiTietHocKy chiTietHocKy)
        {
            var rp = _DangKyMonHocBus.create(chiTietHocKy);
            return Ok(new { data = rp });
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult Put(int monhocid, int hockyid, ChiTietHocKy chiTietHocKy)
        {
            return Ok(new { data = _DangKyMonHocBus.edit(monhocid,hockyid, chiTietHocKy) });
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int monhocid, int hockyid, ChiTietHocKy chiTietHocKy)
        {
            return Ok(new { data = _DangKyMonHocBus.delete(monhocid, hockyid, chiTietHocKy) });
        }
    }
}
