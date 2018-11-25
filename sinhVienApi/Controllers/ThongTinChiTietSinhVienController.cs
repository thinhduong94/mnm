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
    [Route("api/ThongTinChiTietSinhVien")]
    [ApiController]
    public class ThongTinChiTietSinhVienController : ControllerBase
    {
        private readonly ThongTinChiTietSinhVienBus _ThongTinChiTietSinhVienBus;
        private readonly apiContext _context;
        public ThongTinChiTietSinhVienController(apiContext context)
        {
            _context = context;
            _ThongTinChiTietSinhVienBus = new ThongTinChiTietSinhVienBus(_context);
        }
        // GET api/values
        [HttpGet,Route("")]
        public ActionResult Get()
        {
            return Ok(new { data = _ThongTinChiTietSinhVienBus.getAll() });
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(new { data = _ThongTinChiTietSinhVienBus.getById(id) });
        }
    }
}
