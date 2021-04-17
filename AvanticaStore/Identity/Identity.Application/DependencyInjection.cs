using Identity.Application.Users.Queries;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Identity.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddTransient<IUserQuery, UserQuery>();
            
            return services;
        }
    }
}
