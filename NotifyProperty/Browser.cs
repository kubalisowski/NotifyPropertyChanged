using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace NotifyProperty
{
    public class Browser : BrowserInterface
    {
        private string _searcherror = @"Unknown error :(";
        private string _url;
        public string Url
        {
            get
            {
                return _url;
            }
            set
            {
                _url = value;
            }
        }

        public void BrowserScript(string text)
        {
            System.Diagnostics.Process.Start(text);
        }

        public void OpenBrowser(string engine, string text)
        {       
            Dictionary<string, string> client = new Dictionary<string, string>();
            client.Add("google", "https://www.google.com/search?q=");
            client.Add("yahoo", "https://search.yahoo.com/search?p=");
            switch (engine)
            {
                case "google":
                    try
                    {
                        BrowserScript(client[engine] + text);
                    }
                    catch
                    {
                        MessageBox.Show(_searcherror);
                        break;
                    }

                    break;

                case "yahoo":
                    try
                    {
                        BrowserScript(client[engine] + text);
                    }
                    catch
                    {
                        MessageBox.Show(_searcherror);
                        break;
                    }
                    break;
            }
        }
    }
}
