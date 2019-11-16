using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Jawla.DAL.Infrastructure;

namespace Jawla.DAL.Extension
{
    public static class EntityBaseExtensions
    {
        public static void ConfigureRepositoryWrapper(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
        }
    }
}
