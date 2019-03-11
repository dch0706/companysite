using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;
using VanLanschot.Feature.VolleyGroup.Repositories;

namespace VanLanschot.Feature.VolleyGroup.IoC
{
    public class RegisterDependencies : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IXdbRepository, XdbRepository>();
        }
    }
}