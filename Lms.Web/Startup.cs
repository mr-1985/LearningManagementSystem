using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Lms.Core.Services;
using Lms.Core.Services.Interfaces;
using Lms.DataLayer.Context;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Lms.Core.Convertors;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Lms.Web
{
    public class Startup
    {
        public IConfiguration Configuration { get; set; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            #region Authentication

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            }).AddCookie(options =>
            {
                options.LoginPath = "/Login";
                options.LogoutPath = "/Logout";
                options.ExpireTimeSpan = TimeSpan.FromMinutes(43200);
            });
            #endregion

            services.AddControllersWithViews();

            services.AddHttpContextAccessor();
           

            #region DataBase Context

            services.AddDbContext<LmsContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("LmsConnection"));
            });
            #endregion

            #region IOC
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IPermissionService, PermissionService>();
            services.AddTransient<ICommonService, CommonService>();
            services.AddTransient<IOrderService, OrderService>();
            services.AddTransient<ICourseService, CourseService>();
            services.AddTransient<IVirtualClasses, VirtualClasses>();
            services.AddTransient<IExamService, ExamService>();
            services.AddTransient<INewsService, NewsService>();
            services.AddTransient<IViewRenderService, RenderViewToString>();
            services.AddTransient<IImageService, ImageService>();
            //services.AddTransient<IEmailSender, EmailSender>();
            //services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddHttpContextAccessor();

            #endregion

            services.AddAuthorization(options =>
            {
                options.AddPolicy("ThisRolesOnly",
                    policyBuilder =>
                    {
                        //policyBuilder.RequireClaim(ClaimTypes.NameIdentifier,"1","4");
                        policyBuilder.RequireClaim(ClaimTypes.Role, "5","1");
                    }
                );
            });

            services.AddMvc().AddNewtonsoftJson();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();

                endpoints.MapControllerRoute(
                    name: "areas",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello World!");
            //    });
            //});
        }
    }
}
