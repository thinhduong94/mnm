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
        public DbSet<SinhVien> SinhVien { get; set; }
        public DbSet<Nganh> Nganh { get; set; }
        public DbSet<Lop> Lop { get; set; }
        public DbSet<Khoa> Khoa { get; set; }

        public DbSet<HocKy> HocKy { get; set; }
        public DbSet<ChiTietHocKy> ChiTietHocKy { get; set; }
        public DbSet<MonHoc> MonHoc { get; set; }
        public DbSet<NamHoc> NamHoc { get; set; }

    }
}
