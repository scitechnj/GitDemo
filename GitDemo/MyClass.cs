using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GitDemo
{
    public class MyClass
    {
        private readonly int _x;

        public void GetGoogleHtml()
        {
            using (var webclient = new WebClient())
            {
                Console.WriteLine(webclient.DownloadString("http://www.google.com"));
            }
        }

        public void Foobar()
        {
            
        }

    }
}
