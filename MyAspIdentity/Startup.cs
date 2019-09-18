using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyAspIdentity.Data;
using MyAspIdentity.Infrastructure;
using MyAspIdentity.Models;

namespace MyAspIdentity
{
    public class Startup
    {public Startup(IHostingEnvironment env)
        {
            Configuration = new ConfigurationBuilder().
                SetBasePath(env.ContentRootPath).
                AddJsonFile("appsettings.json").Build();
        }
        public IConfigurationRoot Configuration { get; }


        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {


            services.AddDbContext<MideIdentityDbContext>(options =>
            options.UseSqlServer(Configuration["Data:MyAspIdentity:ConnectionString"]));
            //registering my custom validstor
           // services.AddTransient<IPasswordValidator<MideUser>, CustomPasswordValidator>();

            services.AddTransient<IUserValidator<MideUser>, CustomUserValidation>();
            //custom password settings
            services.AddIdentity<MideUser, IdentityRole>(opts=>
            {
                opts.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyz";
                opts.User.RequireUniqueEmail = true;
                opts.Password.RequiredLength = 7;
                opts.Password.RequireNonAlphanumeric = false;
                opts.Password.RequireLowercase = false;
                opts.Password.RequireDigit = false;
                opts.Password.RequireUppercase = false;
            }).
                AddEntityFrameworkStores<MideIdentityDbContext>().
                AddPasswordValidator<CustomPasswordValidator<MideUser>>(); //generic way. registering my custom user too
            //configuring the access denied path as well as login path
            services.ConfigureApplicationCookie(opt => opt.LoginPath = "/MyAccount/Login");
            services.ConfigureApplicationCookie(opt => opt.AccessDeniedPath = "/MyAccount/AccessDenied");
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
           
            app.UseStatusCodePages();
            app.UseStaticFiles();
           // app.UseIdentity();
            app.UseAuthentication();
            app.UseMvcWithDefaultRoute();
            MideIdentityDbContext.CreateAdminAccount(app.ApplicationServices, Configuration).Wait();
            
        }
    }
}
