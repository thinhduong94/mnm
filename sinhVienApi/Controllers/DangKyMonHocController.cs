using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sinhVienApi.Bus;
using sinhVienApi.Entity;
using sinhVienApi.Model;
using sinhVienApi.ViewModel;

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
        public ActionResult Post(View_DangKyMonHoc item)
        {
            var chitiethockis = new List<ChiTietHocKy>();
            foreach (int i in item.MonHocList)
            {
                var chitiethocki = new ChiTietHocKy();
                chitiethocki.HocKy_Id = item.HocKy_Id;
                chitiethocki.MonHoc_Id = i; // lay ra tu list mon hoc
                chitiethocki.Diem = 0;// dang ki luc nao diem cung = 0;
                chitiethockis.Add(chitiethocki);
            }
            _context.ChiTietHocKy.AddRange(chitiethockis);
            _context.SaveChanges();
            return Ok(true);
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
