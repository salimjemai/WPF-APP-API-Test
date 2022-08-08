using API_TESTER_USING_MVVM.Models;
using Caliburn.Micro;

namespace API_TESTER_USING_MVVM.ViewModels
{
    public class ShellViewModel : Screen
    {
        private string _schemaAlias;
        private string _userName;
        private string _password;
        private string _cwsUrl;
        private BindableCollection<SessionModel> _session = new BindableCollection<SessionModel>();

        public ShellViewModel()
        {
            Session.Add(new SessionModel { SchemaAlias = "QA12c_V11_UC_1", UserName = "cati", Password = "PgacdE", CwsUrl = "http://extdev6win10/cws/" });
        }
        public string SchemaAlias
        {
            get
            {
                return _schemaAlias;
            }
            set
            {
                _schemaAlias = value;
                NotifyOfPropertyChange(() => SchemaAlias);
            }
        }


        public string UserName
        {
            get { return _userName; }
            set
            {
                _userName = value;
                NotifyOfPropertyChange(() => UserName);
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                NotifyOfPropertyChange(() => Password);
            }
        }

        public string CwsUrl
        {
            get { return _cwsUrl; }
            set
            {
                _cwsUrl = value;
                NotifyOfPropertyChange(() => CwsUrl);
            }
        }



        public BindableCollection<SessionModel> Session
        {
            get { return _session; }
            set { _session = value; }
        }


    }
}
