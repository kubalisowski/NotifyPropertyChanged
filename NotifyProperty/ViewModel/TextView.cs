using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotifyProperty.ViewModel
{
    //Class related to paricular object in GUI
    public class TextView : ObservableObject
    {
        private string _text;
        public string Text
        {
            get
            {
                if (string.IsNullOrEmpty(_text))
                    return "!Max 18 characters!";

                return _text;
            }
            set
            {
                _text = value;
                OnPropertyChanged("Text");
            }
        }
    }
}
