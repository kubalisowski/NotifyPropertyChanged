using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotifyProperty.ViewModel
{
    // This class combines view as below
    class MainView
    {
        public TextView Text { get; set; }

        public MainView()
        {
            Text = new TextView();
        }

    }
}
