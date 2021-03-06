using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using CommuneLetters.Models;
using Microsoft.EntityFrameworkCore;
using Stripe;
using CommuneLetters.data;
using System.Web;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace CommuneLetters
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
            services.AddControllersWithViews();
            
            services.AddDbContext<AdminDBContext>(options => options.UseSqlServer(Configuration.GetConnectionString("Myconnection")));
            
            services.AddDbContext<ClientDBContext>(options => options.UseSqlServer(Configuration.GetConnectionString("MySecondconnection")));

            services.AddControllers().AddNewtonsoftJson();

            services.Configure<StripeSettings>(Configuration.GetSection("Stripe"));

            services.AddDistributedMemoryCache();


        }
        

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            StripeConfiguration.ApiKey = "sk_test_51IhlLWCIxG1WF7GFSSialMrZownTNjBqGUTnYV6jftYoEvpbq5sIuSB9HrAa1KngpdRkG8BcoHvSNxjzIF03nO2t00vCHZY646";

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
