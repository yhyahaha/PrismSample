using Prism.Ioc;
using PrismSample.Views;
using System.Threading;
using System.Windows;
using ModuleSample;
using Prism.Modularity;

namespace PrismSample
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        private Mutex mutex = new Mutex(false, "yhyahahaPrismSample");

        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }



        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }

        private void PrismApplication_Startup(object sender, StartupEventArgs e)
        {
            if (this.mutex.WaitOne(0, false)) return;

            MessageBox.Show("二重起動できません。", "情報", MessageBoxButton.OK, MessageBoxImage.Information);

            this.mutex.Close();
            this.mutex = null;
            this.Shutdown();
        }

        private void PrismApplication_Exit(object sender, ExitEventArgs e)
        {
            if (this.mutex != null)
            {
                this.mutex.ReleaseMutex();
                this.mutex.Close();
            }
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            base.ConfigureModuleCatalog(moduleCatalog);
            moduleCatalog.AddModule<ModuleSampleModule>();
        }
    }
}
