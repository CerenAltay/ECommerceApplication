using ECommerceApplication.BusinessLayer.Interfaces;
using ECommerceApplication.BusinessLayer.Services;
using ECommerceApplication.DataLayer.Interfaces;
using ECommerceApplication.DataLayer.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerceApplication.DataLayer;

namespace API
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
            services.AddControllers();
            services.AddRazorPages();

            services.AddDbContext<ECommerceAppContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("ECommerceAppContext"));

            });

            // Trigger database creation
            var serviceProvider = services.BuildServiceProvider();
            var dbContext = serviceProvider.GetRequiredService<ECommerceAppContext>();
            dbContext.Database.EnsureCreated();

            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IOrderService, OrderService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                //Configure(app, env);
                app.UseDeveloperExceptionPage();
                //app.UseSpa(spa =>
                //{
                //    spa.Options.SourcePath = "./ECommerceApplication";
                //    spa.UseVueCli(npmScript: "serve");
                //});
            }
            else
            {
                Configure(app, env);
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            //remark:url that the UI runs
            //remark:for CORS to work certificate added to the trusted certificates in windows certicate manager
            app.UseCors(options =>
            {
                options.AllowAnyHeader()
                .AllowAnyMethod()
                .AllowAnyOrigin();
                //.AllowCredentials();
            });
            

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseStaticFiles();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                //endpoints.MapRazorPages();
            });
        }
    }
}
