using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using API_TESTER_USING_MVVM.Models;

namespace API_TESTER_USING_MVVM.ViewModels
{
    class AboutViewModel : Utilities.ViewModelBase
    {
        private readonly AboutModel _aboutModel;
        public string AboutTitle 
        {
            get { return _aboutModel.AboutTitle; }
            set { _aboutModel.AboutTitle = value; OnPropertyChanged(); } 
        }


        public string AboutDescription
        {
            get { return _aboutModel.AboutDescription; }
            set { _aboutModel.AboutDescription = value; OnPropertyChanged(); } 
        }

        public string Version
        {
            get { return _aboutModel.version; }
            set { _aboutModel.version = value; OnPropertyChanged(); }
        }

        public AboutViewModel()
        {
            _aboutModel = new AboutModel();
            AboutTitle = "Corridor API Teseter";
            AboutDescription = "This application is a Windows Presentation Foundation app that is build to test CORRIDOR API";
            Version = "1.0";
        }

    }
}
