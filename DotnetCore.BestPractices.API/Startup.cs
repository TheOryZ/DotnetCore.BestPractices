using DotnetCore.BestPractices.Core.Interfaces.Repositories;
using DotnetCore.BestPractices.Core.Interfaces.Services;
using DotnetCore.BestPractices.Core.Interfaces.UnitOfWorks;
using DotnetCore.BestPractices.Data.Concrete.EntityFrameworkCore.Context;
using DotnetCore.BestPractices.Data.Concrete.EntityFrameworkCore.Repositories;
using DotnetCore.BestPractices.Data.Concrete.EntityFrameworkCore.UnitOfWorks;
using DotnetCore.BestPractices.Service.Containers.MicrosoftIoC;
using DotnetCore.BestPractices.Service.Services;
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

namespace DotnetCore.BestPractices.API
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
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(Configuration["ConnectionStrings:ConnectionName"].ToString(), o => {
                    o.MigrationsAssembly("DotnetCore.BestPractices.Data");
                });
            });
            services.AddAutoMapper(typeof(Startup));
            services.AddDependencies();

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "DotnetCore.BestPractices.API", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "DotnetCore.BestPractices.API v1"));
            }
            // TODO : Swagger ?zerinde DTO nesneleri g?z?kmemekte. Tekrardan kontrol edilecek.
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
