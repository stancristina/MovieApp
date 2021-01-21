using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MovieApp.Controllers;
using MovieApp.Helpers;
using MovieApp.IRepositories;
using MovieApp.IServices;
using MovieApp.Repositories;
using MovieApp.Services;

namespace MovieApp
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
            services.AddScoped<IUserService, UserService>();
            services.AddControllersWithViews();
            // In production, the Angular files will be served from this directory
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/dist";
            });
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IActorRepository, ActorRepository>();
            services.AddTransient<IMovieRepository, MovieRepository>();
            services.AddTransient<IGenreRepository, GenreRepository>();
            services.AddTransient<IProductionRepository, ProductionRepository>();
            services.AddTransient<IMoviePremierRepository, MoviePremierRepository>();
            services.AddTransient<IMovieCastRepository, MovieCastRepository>();
            services.AddTransient<IMovieGenreRepository, MovieGenreRepository>();

            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IActorService, ActorService>();
            services.AddTransient<IMovieService, MovieService>();
            services.AddTransient<IGenreService, GenreService>();
            services.AddTransient<IProductionService, ProductionService>();
            services.AddTransient<IMoviePremierService, MoviePremierService>();
            services.AddTransient<IMovieCastService, MovieCastService>();
            services.AddTransient<IMovieGenreService, MovieGenreService>();
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            if (!env.IsDevelopment())
            {
                app.UseSpaStaticFiles();
            }

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            // custom jwt auth middleware
            app.UseMiddleware<JwtMiddleware>();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller}/{action=Index}/{id?}");
            });

            app.UseSpa(spa =>
            {
                // To learn more about options for serving an Angular SPA from ASP.NET Core,
                // see https://go.microsoft.com/fwlink/?linkid=864501

                spa.Options.SourcePath = "ClientApp";

                if (env.IsDevelopment())
                {
                    spa.UseAngularCliServer(npmScript: "start");
                }
            });
        }
    }
}
