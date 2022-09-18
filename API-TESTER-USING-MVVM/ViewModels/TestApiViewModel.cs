using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using API_TESTER_USING_MVVM.Models;

namespace API_TESTER_USING_MVVM.ViewModels
{
    class TestApiViewModel : Utilities.ViewModelBase
    {
        public readonly TestApiModel _testApiModel; 

        public string ComboBoxLabel
        {
            get { return _testApiModel.ComboBoxLabel; }
            set { _testApiModel.ComboBoxLabel = value; OnPropertyChanged(); }
        }

        public List<string> ApiListComboBox
        {
            get { return _testApiModel.ApiListComboBox; }
            set { _testApiModel.ApiListComboBox = value; OnPropertyChanged(); }
        }


        public TestApiViewModel()
        {
            _testApiModel = new TestApiModel();
            ComboBoxLabel = "Select an API you wish to test";
            ApiListComboBox.Add("Company Database") ;
            ApiListComboBox.Add("User Management");
            ApiListComboBox.Add("Accounting");
            ApiListComboBox.Add("Aircraft Ownership");
        }
    }
}
