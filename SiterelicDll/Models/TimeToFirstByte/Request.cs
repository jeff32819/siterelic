using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiterelicDll.Models.TimeToFirstByte
{

    public class Request
    {
        public bool followRedirect { get; set; }
        public string url { get; set; }
    }
}
