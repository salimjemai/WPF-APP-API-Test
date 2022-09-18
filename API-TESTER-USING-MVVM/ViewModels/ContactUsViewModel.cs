using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using API_TESTER_USING_MVVM.Models;

namespace API_TESTER_USING_MVVM.ViewModels
{
    class ContactUsViewModel : Utilities.ViewModelBase
    {
        private readonly ContactUsModel _contactUsModel;
        public string EmailAddress
        {
            get { return _contactUsModel.EmailAddress; }
            set { _contactUsModel.EmailAddress = value; OnPropertyChanged(); }
        }

        public string PhoneNumber
        {
            get { return _contactUsModel.PhoneNumber; }
            set { _contactUsModel.PhoneNumber = value; OnPropertyChanged(); }
        }

        public string Fax
        {
            get { return _contactUsModel.Fax; }
            set
            {
                _contactUsModel.Fax = value;
                OnPropertyChanged();
            }   
        }

        public string EmailBody
        {
            get { return _contactUsModel.EmailBody; }
            set
            {
                _contactUsModel.EmailBody = value;
                OnPropertyChanged();
            }
        }

        public ContactUsViewModel()
        {
            _contactUsModel = new ContactUsModel();
            PhoneNumber = "512-553-6697";
            Fax = "512-444-8522";
            EmailBody = string.Empty;
        }
    }
}
