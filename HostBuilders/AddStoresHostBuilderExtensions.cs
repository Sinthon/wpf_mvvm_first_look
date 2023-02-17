using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace wpf_mvvm_first_look.HostBuilders
{
    public static class AddStoresHostBuilderExtensions
    {
        public static IHostBuilder AddStores(this IHostBuilder host)
        {
            host.ConfigureServices(services =>
            {
                
            });

            return host;
        }
    }
}
