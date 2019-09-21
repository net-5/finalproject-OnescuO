using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Conference.Data;
using Conference.Domain.Entities;
using Conference.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Conference
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

            services.AddDbContext<ConferenceContext>();

            services.AddTransient<IEditionRepository, EditionRepository>();
            services.AddTransient<IEditionServices, EditionServices>();

            services.AddTransient<ISpeakersRepository, SpeakersRepository>();
            services.AddTransient<ISpeakersServices, SpeakersServices>();

            services.AddTransient<ITalksRepository, TalksRepository>();
            services.AddTransient<ITalksServices, TalksServices>();

            services.AddTransient<IWorkshopRepository, WorkshopRepository>();
            services.AddTransient<IWorkshopServices, WorkshopServices>();

            services.AddTransient<ISponsorsRepository, SponsorsRepository>();
            services.AddTransient<ISponsorsServices, SponsorsServices>();

            services.AddTransient<ISponsorTypesRepository, SponsorTypesRepository>();
            services.AddTransient<ISponsorTypesServices, SponsorTypesServices>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
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
            }

            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                  name: "areas",
                  template: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );
            });
        }
    }
}
