using Glass.Mapper.Sc;
using Microsoft.Extensions.DependencyInjection;
using Sitecore;
using Sitecore.DependencyInjection;

namespace VanLanschot.Foundation.Kernel.IoC
{
    public class RegisterDependencies : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<ISitecoreContext>(provider => new SitecoreContext());
            serviceCollection.AddTransient<ISitecoreService>(provider => new SitecoreService(Context.Database));
        }
    }
}