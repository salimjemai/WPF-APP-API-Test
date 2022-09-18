using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using API_TESTER_USING_MVVM.Models;

namespace API_TESTER_USING_MVVM.ViewModels
{
    class LoginViewModel : Utilities.ViewModelBase
    {
        private readonly LoginModel _loginViewModel;

        public string SchemaAlias
        {
            get { return _loginViewModel.SchemaAlias; }
            set { _loginViewModel.SchemaAlias = value; OnPropertyChanged(); }
        }

        public string UserName
        {
            get { return _loginViewModel.UserName; }
            set { _loginViewModel.UserName = value; OnPropertyChanged(); }  
        }

        // don't save it in the DB
        public string Password
        {
            get { return _loginViewModel.Password; }
            set
            {
                _loginViewModel.Password = value;
                OnPropertyChanged();
            }
        }

        public string CwsUrl
        {
            get { return _loginViewModel.CwsUrl; }
            set
            {
                _loginViewModel.CwsUrl = value;
                OnPropertyChanged();
            }
        }

        public LoginViewModel()
        {
            _loginViewModel = new LoginModel();
            SchemaAlias = string.Empty;
            UserName = string.Empty;
            Password = string.Empty;
            CwsUrl = string.Empty;
        }
    }
}
