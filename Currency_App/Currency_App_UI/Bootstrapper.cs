using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Currency_App_UI.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace Currency_App_UI
{
    public static class Bootstrapper
    {
        public static IServiceProvider Init()
        {
            var services = new ServiceCollection();
            services.AddSingleton<MainWindowViewModel>();
            services.AddTransient<NavBarMenuViewModel>();
            services.AddTransient<SideMenuBarViewModel>();
            return services.BuildServiceProvider();
        }
    }
}
