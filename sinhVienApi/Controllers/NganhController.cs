﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sinhVienApi.Bus;
using sinhVienApi.Entity;

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
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}