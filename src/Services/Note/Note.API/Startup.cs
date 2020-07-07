using System;
using System.Reflection;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Note.API.Application.Queries;
using Note.Infrastructure;

namespace Note.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        private string _connectionStringTemplate = "Server={0};User Id={1};Password={2}";

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            var conStr = string.Format(_connectionStringTemplate, Configuration["NOTEDB_URL"], Configuration["NOTEDB_USERNAME"], Configuration["NOTEDB_PASSWORD"]);

            Console.WriteLine("constr: " + conStr);

            services.AddEntityFrameworkSqlServer().AddDbContext<NoteContext>(options =>
                options.UseSqlServer(conStr));

            services.AddScoped<INoteQueries>(svc =>
            {
                return new NoteQueries(conStr);
            });

            services.AddMediatR(Assembly.GetExecutingAssembly());

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
