using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Commander_Core_3._1_MVC_Rest_Api.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Commander_Core_3._1_MVC_Rest_Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
           
            services.AddDbContext<CommanderContext>
                    (opt => opt.UseSqlServer(Configuration.GetConnectionString("CommanderConnection")));

            services.AddControllers();





            // Automapper DTO
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());




            // 3 manieren voor het registreren van de services
            // 1 AddSingleton (same for every request)
            // 2 AddScoped (created once per client request)
            // 3 AddTransient (new instance created every time)

            // Dus iedere keer als de app vraagt om ICommanderRepo, 
            // geeft deze de MockCommanderRepo. En wil je de vervangen hoeft 
            // dat dus maar op 1 plek te gebeuren

            //// MOCKUP (testing purpose)
            //// services.AddScoped<ICommanderRepo, MockCommanderRepo>();
            
            services.AddScoped<ICommanderRepo, SqlCommanderRepo>();





        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
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
