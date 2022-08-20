using Microsoft.OData.Edm;

namespace API_TESTER_USING_MVVM.Models
{
    public interface ISessionModel
    {
        string CwsUrl { get; set; }

        string Password { get; set; }

        string SchemaAlias { get; set; }

        string UserName { get; set; }

        string SessionToken { get; set; }

        Date? DateCreated { get; set; }

        bool IsTokenValid { get; set; }
    }
}