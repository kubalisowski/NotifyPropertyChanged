using NotifyProperty.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NotifyProperty
{
    public partial class MainWindow : Window
    {
        MainView _main = new MainView();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = _main;
        }

        /// METHODS
        private void Search(string client)
        {
            string msg = textBlock.Text;
            Browser browser = new Browser();
            browser.OpenBrowser(client, msg);
        }
        ////////////////////////////////////////////

        /// BUTTONS
        private void googlebutton_Click(object sender, RoutedEventArgs e)
        {
            Search("google");
        }

        private void yahoobutton_Click(object sender, RoutedEventArgs e)
        {
            Search("yahoo");
        }
        ////////////////////////////////////////////
    }
}
