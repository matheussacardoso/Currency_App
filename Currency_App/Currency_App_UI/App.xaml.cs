using System.Configuration;
using System.Data;
using System.Windows;

namespace Currency_App_UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static IServiceProvider Services { get; private set; }
        protected override void OnStartup(StartupEventArgs e)
        {
            Services = Bootstrapper.Init();
            base.OnStartup(e);
        }
    }

}
