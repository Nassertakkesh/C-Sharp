﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using LoginRegistration.Models;
using Microsoft.EntityFrameworkCore;


namespace LoginRegistration
{
    public class Startup
    {
////////////////////////////////////////////////////
        public Startup(IConfiguration h)
        {
            Configuration = h;
        }
        public IConfiguration Configuration { get; }
////////////////////////////////////////////////////
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSession();    // add this line
            services.AddDbContext<MyContext>(options => options.UseMySql(Configuration["DBInfo:ConnectionString"]));
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }
////////////////////////////////////////////////////
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {app.UseDeveloperExceptionPage();}
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseStaticFiles();
            app.UseSession(); 
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

