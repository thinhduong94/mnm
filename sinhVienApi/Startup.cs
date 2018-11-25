using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using sinhVienApi.Entity;

namespace sinhVienApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            //var hostname = Environment.GetEnvironmentVariable("SQLSERVER_HOST") ?? "192.168.99.100,1500";
            //var password = Environment.GetEnvironmentVariable("SQLSERVER_SA_PASSWORD") ?? "Welkom1234!";
            //var connString = $"Data Source=DESKTOP-TFVS8HE/SQLEXPRESS;Initial Catalog=manageStuentsDb;User ID=sa;Password={password};";
            //var connString = $"Data Source =DESKTOP-TFVS8HE/SQLEXPRESS;Initial Catalog =testDb;Integrated Security = True";
            services.AddDbContext<apiContext>(options => options.UseSqlServer(@"Server=KW1JFKBY6CJHS7O\SQLEXPRESS;Database=mnmDB;Trusted_Connection=True;"));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
