using API_TESTER_USING_MVVM.ViewModels;
using Caliburn.Micro;
using System.Windows;

namespace API_TESTER_USING_MVVM
{
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewForAsync<ShellViewModel>();
        }
    }
}
