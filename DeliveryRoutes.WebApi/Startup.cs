using IBM.EntityFrameworkCore;
using MediatR;
using Middlewares.Authentication;
using DeliveryRoutes.Information.Users;
using DeliveryRoutes.Infrastructure;
using DeliveryRoutes.Infrastructure.Factory;
using DeliveryRoutes.WebApi.Helpers;
using System.Reflection;
using Users.Data;

namespace DeliveryRoutes.WebApi
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddSwaggerGen();

            //services.AddMediatR(typeof(UpdateSensorCommand).GetTypeInfo().Assembly);

            services.AddHealthChecks()
                .AddDbContextCheck<PointsBindingDbContext>();

            services.AddDbContext<PointsBindingDbContext>(options =>
            {
                options.UseDb2(
                    Configuration
                        .GetSection("ConnectionStrings")["Informix"], server => server
                        .SetServerInfo(IBMDBServerType.IDS, IBMDBServerVersion.IDS_12_10_2000));
            });

            services.AddSingleton<IConfiguration>(Configuration);

            services.AddScoped<IPositionsQueries, PositionsQueries>();
            services.AddScoped<IOperationsQueries, OperationsQueries>();
            services.AddScoped<IHttpContextHelper, HttpContextHelper>();
            services.AddScoped<IPointsBindingQueries, PointsBindingQueries>();
            services.AddScoped<IPointsBindingRepository, PointsBindingRepository>();
            services.AddScoped<IUserData, UserData>();

            services.AddSingleton<IDB2ConnectionFactory>((sr) => new DB2ConnectionFactory(Configuration.GetConnectionString("Informix")));

            services.AddScoped<CreatePointsBindingHandler>();
            //services.AddScoped<UpdatePointsBindingHandler>();
            //services.AddScoped<DeletePointsBindingHandler>();

            services.AddMediatR(typeof(CreatePointsBindingCommand).GetTypeInfo().Assembly);
            services.AddMediatR(typeof(UpdatePointsBindingCommand).GetTypeInfo().Assembly);
            services.AddMediatR(typeof(DeletePointsBindingCommand).GetTypeInfo().Assembly);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMiddleware<Middleware>();

            app.UseRouting();

            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                //endpoints.MapHealthChecks("/health");
            });
        }
    }
}