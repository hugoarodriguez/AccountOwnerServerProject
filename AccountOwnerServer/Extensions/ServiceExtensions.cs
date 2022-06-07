using AccountOwnerServer.Data;
using AccountOwnerServer.Data.Repositories;

namespace AccountOwnerServer.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", 
                    builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
            });
        }

        public static void ConfigureIISIntegration(this IServiceCollection services)
        {
            services.Configure<IISOptions>(options => { });
        }

        public static void ConfigureMySqlContext(this IServiceCollection services, IConfiguration config)
        {
            var mySQLConnectionString = new MySQLConfiguration(config.GetConnectionString("MySqlConnection"));

            services.AddSingleton(mySQLConnectionString);
        }

        public static void ConfigureRepositories(this IServiceCollection services)
        {
            services.AddScoped<IOwnerRepository, OwnerRepository>();
        }
    }
}
