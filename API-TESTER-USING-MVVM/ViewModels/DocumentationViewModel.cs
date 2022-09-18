using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using API_TESTER_USING_MVVM.Models;

namespace API_TESTER_USING_MVVM.ViewModels
{
    class DocumentationViewModel : Utilities.ViewModelBase
    {
        public readonly DocumentationModel _documentationModel;

        public string ApiHelpFilePath
        {
            get { return _documentationModel.ApiHelpFilePath; }
            set { _documentationModel.ApiHelpFilePath = value; OnPropertyChanged(); }
        }

        public DocumentationViewModel()
        {
            _documentationModel = new DocumentationModel();
            ApiHelpFilePath = "/APIDocumentation/CorridorAPI.chm";
        }
    }
}

//System.Diagnostics.Process.Start(@"C:\path-to-chm-file.chm");