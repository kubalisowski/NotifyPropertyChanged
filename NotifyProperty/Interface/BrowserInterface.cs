using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NotifyProperty
{
    interface BrowserInterface
    {
        void BrowserScript(string text);
        void OpenBrowser(string engine, string text);
    }
}
