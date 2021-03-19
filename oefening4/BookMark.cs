using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace oefening4
{
    class BookMark
    {
        public  string Naam { get; set; }

        public string URL { get; set; }

        public void OpenSite(string URL)
        {
            Process.Start(@"C:Program Files (x86)\Google\Chrome\Application\chrome.exe", URL);
        }
    }
}
