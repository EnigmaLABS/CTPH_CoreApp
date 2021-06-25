using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

using CTPH_CoreBusiness.ActionInterface;
using CTPH_CoreBusiness.BusinessActions;
using CTPH_CoreApp.Config;

namespace CTPH_CoreApp
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

#if DEBUG

            var configbuilder = new ConfigurationBuilder()
                            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                            .AddJsonFile("appsettings.Development.json").Build();
#endif

#if RELEASE
            var configbuilder = new ConfigurationBuilder()
                            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                            .AddJsonFile("appsettings.json").Build();
#endif

            var section = configbuilder.GetSection(nameof(ClientConfig));
            var config = section.Get<ClientConfig>();

            ConfigureServices();
            Application.Run(new frmApp(config));
        }

        static void ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddTransient<IMuestraAction, MuestraAction>();
            services.AddTransient<IElementoAction, ElementoAction>();
        }
    }
}
