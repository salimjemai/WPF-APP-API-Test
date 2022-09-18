using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_TESTER_USING_MVVM.Models
{
    public class PageModel
    {
        public string SchemaAlias { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string CwsUrl { get; set; }
        public DateTime SessionCreatedAt { get; set; }
        public bool IsSessionValid { get; set; }
    }
}
