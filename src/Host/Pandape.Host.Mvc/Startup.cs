using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Pandape.Application.AppServices;
using Pandape.Application.CQRS.Queries;
using Pandape.Application.Mapping;
using Pandape.Host.Mvc.ViewModels;
using Pandape.Infrastructure.Persistence.DataBase;
using Pandape.Infrastructure.Persistence.Repositories;
using Serilog;

namespace Pandape.Host.Mvc
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

            Log.Logger = new LoggerConfiguration()
               .ReadFrom.Configuration(configuration)
               .CreateLogger();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Startup).Assembly));

            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(GetAllCandidatesQuery).Assembly));

            services.AddAutoMapper(typeof(Startup).Assembly);

            services.AddAutoMapper(typeof(CandidateAppProfile).Assembly);

            services.AddDbContext<PandapeContext>(options => options.UseSqlServer(Configuration.GetConnectionString("PandapeContext")));

            services.AddScoped<ICandidateCommandRepository, CandidateCommandRepository>();

            services.AddScoped<ICandidateQueryRepository, CandidateQueryRepository>();

            services.AddScoped<ICandidateExperienceCommandRepository, CandidateExperienceCommandRepository>();

            services.AddScoped<ICandidateExperienceQueryRepository, CandidateExperienceQueryRepository>();

            services.AddScoped<ICommandCandidateAppService, CommandCandidateAppService>();

            services.AddScoped<IQueryCandidateAppService, QueryCandidateAppService>();

            services.AddScoped<IQueryCandidateAndExperiencesAppService, QueryCandidateAndExperiencesAppService>();

            services.AddScoped<ICandidateViewModelFactory, CandidateViewModelFactory>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
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
