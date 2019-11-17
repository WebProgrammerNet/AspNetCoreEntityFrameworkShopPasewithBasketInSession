using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Shop_Page.DAL;
using Shop_Page.Interfaces;
using Shop_Page.Mocks;
using Shop_Page.Models;
using Shop_Page.Repository;

namespace Shop_Page
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

        }
        public IConfiguration Configuration { get; set; }
       // private IConfigurationRoot _config;

        //public Startup(IHostingEnvironment hostenv)
        //{
        //    _config = new ConfigurationBuilder().SetBasePath(hostenv.ContentRootPath).AddJsonFile("appsettings.json").Build();
        //}

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            //services.AddTransient<IAllCar, MockAllCars>();
            //services.AddTransient<IAllCategory, MockAllCategory>();
            services.AddTransient<IAllCar, CarRepository>();
            services.AddTransient<IAllCategory, CategoryRepository>();
            services.AddTransient<IAllorders, OrderRepository>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped(sp =>ShopCart.GetCart(sp));
            //services.Configure<CookiePolicyOptions>(options =>
            //{
            //    // This lambda determines whether user consent for non-essential cookies is needed for a given request.
            //    options.CheckConsentNeeded = context => true;
            //    options.MinimumSameSitePolicy = SameSiteMode.None;
            //});

            services.AddDbContext<ShopDb>(options =>
            {
                options.UseSqlServer(Configuration["ConnectionStrings:DefaultConnection"]);
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddMemoryCache();
            services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
    
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseSession();
            //app.UseMvcWithDefaultRoute();
          

           
            using (var scope = app.ApplicationServices.CreateScope())
            {

              ShopDb  content = scope.ServiceProvider.GetRequiredService<ShopDb>();
                DbObjects.Initial(content);
            };

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");

                //routes.MapRoute( // Bu yazilis formasi da var!!!
                //   name: "CategoryFilter",
                //   template: "{controller=Car}/{action=Index}/{category?}", defaults: new { controller = "Car", action = "Index"});
            });



        }
    }
}
