using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace WPFFahrkartenautomat
{
    /// <summary>
    /// Interaktionslogik für Startseite.xaml
    /// </summary>
    public partial class Startseite : Page
    {


        public Startseite()
        {
            InitializeComponent();
        }      
        
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            string selticket = btn.Name;

            Ticket Selticket = new Ticket();

            switch (selticket)
            {
                case "ABC":
                    Selticket.Area = Areas2Price.ABC;
                    break;
                case "AB":
                    Selticket.Area = Areas2Price.AB;
                    break;
                case "BC":
                    Selticket.Area = Areas2Price.BC;
                    break;
            }

            this.NavigationService.Navigate(new Ticketkauf(Selticket));
        }
    }
}
