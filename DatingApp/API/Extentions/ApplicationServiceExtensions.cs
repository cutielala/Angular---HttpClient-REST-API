using API.Interfaces;
using API.Services;
using Microsoft.EntityFrameworkCore;

namespace API.Extentions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config){
            
            services.AddScoped<ITokenService, TokenService>();
            services.AddDbContext<Data.DataContext>(options =>
           {
               options.UseSqlite(config.GetConnectionString("DefaultConnection"));

           });
           return services;
        }
    }
}