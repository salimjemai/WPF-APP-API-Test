using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using API_TESTER_USING_MVVM.Utilities;

namespace API_TESTER_USING_MVVM.ViewModels
{
    class NavigationViewModel : ViewModelBase
    {
        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value; OnPropertyChanged(); }
        }

        public ICommand LoginCommand { get; set; }
        public ICommand HomeCommand { get; set; }
        public ICommand AboutCommand { get; set; }
        public ICommand DocumentationCommand { get; set; }
        public ICommand ContactUsCommand { get; set; }
        public ICommand SettingsCommand { get; set; }
        public ICommand TestApiCommand { get; set; }

        private void Login(Object obj) =>CurrentView = new LoginViewModel();
        private void Home(Object obj) => CurrentView = new HomeViewModel();
        private void About(Object obj) => CurrentView = new AboutViewModel();
        private void Documentation(Object obj) => CurrentView = new DocumentationViewModel();
        private void ContactUs(Object obj) => CurrentView = new ContactUsViewModel();
        private void Settings(Object obj) => CurrentView = new SettingsViewModel();
        private void TestApi(Object obj) => CurrentView = new TestApiViewModel();

        public NavigationViewModel()
        {
            LoginCommand = new RelayCommand(Login);
            HomeCommand = new RelayCommand(Home);
            AboutCommand = new RelayCommand(About);
            DocumentationCommand = new RelayCommand(Documentation);
            ContactUsCommand = new RelayCommand(ContactUs);
            SettingsCommand = new RelayCommand(Settings);
            TestApiCommand = new RelayCommand(TestApi);

            // startup page
            CurrentView = new LoginViewModel();
        }
    }
}
