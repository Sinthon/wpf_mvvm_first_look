using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpf_mvvm_first_look.HostBuilders
{
    public static class AddConfigurationHostBuilderExtensions
    {
        public static IHostBuilder AddConfiguration(this IHostBuilder host)
        {
            host.ConfigureAppConfiguration(conf =>
            {
                conf.AddJsonFile("./appsettings.json");
                conf.AddEnvironmentVariables();
            });

            return host;
        }
    }
}
