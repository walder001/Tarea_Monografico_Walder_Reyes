﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Tarea_Monografico_Walder_Reyes.Models;

namespace Tarea_Monografico_Walder_Reyes
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            //----------------------------------------------------------
            // Verifica cual conexion usar... produccion y desarrollo
            //-------------
            string connStr = Configuration.GetConnectionString("prodConn");
            if (Configuration.GetSection("AppSettings")["EnProduccion"].Equals("NO"))
                connStr = Configuration.GetConnectionString("devConn");

            /// depency injection del la conexion del sql a los controllers
			services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connStr),
                ServiceLifetime.Scoped);

            //services.AddDbContext<OldDbContext>(options => options.UseSqlServer(connStr),
            //ServiceLifetime.Scoped);

            services.Configure<AppSettings>(Configuration.GetSection("AppSettings")); //inyecta los datos constantes de la app.

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
