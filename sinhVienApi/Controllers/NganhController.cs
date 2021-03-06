﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sinhVienApi.Bus;
using sinhVienApi.Entity;
using sinhVienApi.Model;

namespace sinhVienApi.Controllers
{
    [Route("api/Nganh")]
    [ApiController]
    public class NganhController : ControllerBase
    {
        private readonly NganhBus _nganhBus;
        private readonly apiContext _context;
        public NganhController(apiContext context)
        {
            _context = context;
            _nganhBus = new NganhBus(_context);
        }
        // GET api/values
        [HttpGet,Route("")]
        public ActionResult Get()
        {
            return Ok(new { data = _nganhBus.getAll() });
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(new { data = _nganhBus.getById(id) });
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post(Nganh nganh)
        {
            var rp = _nganhBus.create(nganh);
            return Ok(new { data = rp });
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult Put(int id,Nganh nganh)
        {
            return Ok(new { data = _nganhBus.edit(id,nganh)});
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(new { data = _nganhBus.delete(id) });
        }
    }
}
