using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiPhasmophobia.Data;
using WebApiPhasmophobia.Repositories;

namespace WebApiPhasmophobia
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
            String cadenaconexion = Configuration.GetConnectionString("phasmoazure");

            //Equipments
            services.AddTransient<RepositoryEquipments>();
            services.AddDbContext<EquipmentsContext>(options => options.UseSqlServer(cadenaconexion));

            ////Ghosts
            //services.AddTransient<RepositoryGhosts>();
            //services.AddDbContextGhostsContext > (options => options.UseSqlServer(cadenaconexion));

            ////Maps
            //services.AddTransient<RepositoryMaps>();
            //services.AddDbContextMapsContext > (options => options.UseSqlServer(cadenaconexion));
            services.AddMvc();
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
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
