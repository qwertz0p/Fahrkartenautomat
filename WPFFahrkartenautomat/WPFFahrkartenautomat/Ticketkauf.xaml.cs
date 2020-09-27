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
using System.Diagnostics;
using System.Globalization;

namespace WPFFahrkartenautomat
{
    /// <summary>
    /// Interaktionslogik für Ticketkauf.xaml
    /// </summary>
    public partial class Ticketkauf : Page
    {
        double geldeinwurf = 0;
        public Ticket Selection = new Ticket();


        public Ticketkauf()
        {
            InitializeComponent();
            this.DataContext = Selection;
        }

        public Ticketkauf(Areas selarea, double selprice) : this()
        {
            Selection.Area = selarea;
            Selection.Price = selprice;
        }

        private void Cancel_Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Startseite());
        }


        //Hier wiederholt sich Code!! Es muss also umdesignt werden :-)

        #region Geldeinwurf
        private void Cent10_Click(object sender, RoutedEventArgs e)
        {
            geldeinwurf += 0.1;
            Selection.TicketBezahlen(geldeinwurf);
        }

        private void Cent20_Click(object sender, RoutedEventArgs e)
        {
            geldeinwurf += 0.2;
            Selection.TicketBezahlen(geldeinwurf);
        }

        private void Cent50_Click(object sender, RoutedEventArgs e)
        {
            geldeinwurf += 0.5;
            Selection.TicketBezahlen(geldeinwurf);
        }

        private void Euro1_Click(object sender, RoutedEventArgs e)
        {
            geldeinwurf += 1;
            Selection.TicketBezahlen(geldeinwurf);
        }

        private void Euro2_Click(object sender, RoutedEventArgs e)
        {
            geldeinwurf += 2;
            Selection.TicketBezahlen(geldeinwurf);
        }

        private void Euro5_Click(object sender, RoutedEventArgs e)
        {
            geldeinwurf += 5;
            Selection.TicketBezahlen(geldeinwurf);
        }

        private void Euro10_Click(object sender, RoutedEventArgs e)
        {
            geldeinwurf += 10;
            Selection.TicketBezahlen(geldeinwurf);
        }

        private void Euro20_Click(object sender, RoutedEventArgs e)
        {
            geldeinwurf += 20;
            Selection.TicketBezahlen(geldeinwurf);
        }

        #endregion
    }
}
