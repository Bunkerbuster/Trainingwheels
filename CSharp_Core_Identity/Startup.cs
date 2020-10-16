
using CSharp_Core_Identity.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;

namespace CSharp_Core_Identity
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            /// EnableEndPointRouting:  https://github.com/dotnet/aspnetcore/issues/9542
            services.AddMvc(option => option.EnableEndpointRouting = false);

            services.AddIdentityCore<User>(options => { });

            services.AddScoped<IUserStore<User>, UserStore>();

            services.AddAuthentication().AddCookie("cookies", options => options.LoginPath = "/Home/Login");

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();


            /// EnableEndPointRouting:  https://github.com/dotnet/aspnetcore/issues/9542
            app.UseMvc(routes => 
            {
                routes.MapRoute(
                    name: "default", 
                    template : "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
