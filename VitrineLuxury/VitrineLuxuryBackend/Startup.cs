using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VitrineLuxury.Core.DataAccess;
using VitrineLuxury.Core.Service;
using VitrineLuxury.Core.UnitOfWorks;
using VitrineLuxury.DataAccess;
using VitrineLuxury.DataAccess.Concrete;
using VitrineLuxury.DataAccess.UnitOfWorks;
using VitrineLuxury.Repository;
using VitrineLuxury.Service.Abstract;
using VitrineLuxury.Service.Concrete;
using AutoMapper;
using Newtonsoft;
using VitrineLuxury.Core.Utilities.IoC;
using VitrineLuxury.Core.DependencyResolvers;
using VitrineLuxury.Core.Extension;

namespace VitrineLuxuryBackend
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
            services.AddAutoMapper(typeof(Startup));


            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(Configuration["ConnectionStrings:SqlConnectionString"].ToString(), o =>
                {
                    o.MigrationsAssembly("VitrineLuxury.DataAccess");
                });
            });
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "VitrineLuxuryAPI", Version = "v1" });
            });

            services.AddControllers().AddNewtonsoftJson(options =>
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
);

            services.AddDependencyResolvers(new ICoreModule[] {
               new CoreModule()
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "VitrineLuxuryBackend v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
