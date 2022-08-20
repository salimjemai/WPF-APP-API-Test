using Microsoft.OData.Edm;

namespace API_TESTER_USING_MVVM.Models
{
    public class SessionModel : ISessionModel
    {
        public string SchemaAlias { get; set; }

        public string UserName { get; set; }

        // don't save it in the DB
        public string Password { get; set; }

        public string CwsUrl { get; set; }

        public string SessionToken { get; set; }

        public Date? DateCreated { get; set; }

        public bool IsTokenValid{ get; set; } = false;


    }
}
