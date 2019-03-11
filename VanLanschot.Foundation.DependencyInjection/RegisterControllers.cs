using Sitecore.DependencyInjection;
using VanLanschot.Foundation.DependencyInjection.Extensions;

namespace VanLanschot.Foundation.DependencyInjection
{
    public class RegisterControllers : IServicesConfigurator
    {
        public void Configure(Microsoft.Extensions.DependencyInjection.IServiceCollection serviceCollection)
        {
            serviceCollection.AddMvcControllers(
                "VanLanschot.Feature.*");
        }
    }
}