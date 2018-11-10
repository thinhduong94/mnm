using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using sinhVienApi.Model;

namespace sinhVienApi.Entity
{
    public class apiContext: DbContext
    {
        public apiContext(DbContextOptions<apiContext> options)
            : base(options)
        {
            this.Database.EnsureCreated();
        }
        public DbSet<Nganh> Nganh { get; set; }
    }
}
