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
        CultureInfo culture = new CultureInfo("de-DE");

        public Ticketkauf()
        {
            InitializeComponent();
            this.DataContext = Selection;
        }

        public Ticketkauf(Areas selarea, double selprice) : this()
        {
            Selection.Area = selarea;
            Selection.Price = selprice;
            Selection.PriceEuro = selprice.ToString("c", culture);
        }

        private void Cancel_Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Startseite());
        }

        private void Cent10_Click(object sender, RoutedEventArgs e)
        {
            geldeinwurf += 0.1;
        }

        private void Cent20_Click(object sender, RoutedEventArgs e)
        {
            geldeinwurf += 0.2;
        }

        private void Cent50_Click(object sender, RoutedEventArgs e)
        {
            geldeinwurf += 0.5;
        }

        private void Euro1_Click(object sender, RoutedEventArgs e)
        {
            geldeinwurf += 1;
        }

        private void Euro2_Click(object sender, RoutedEventArgs e)
        {
            geldeinwurf += 2;
        }

        private void Euro5_Click(object sender, RoutedEventArgs e)
        {
            geldeinwurf += 5;
        }

        private void Euro10_Click(object sender, RoutedEventArgs e)
        {
            geldeinwurf += 10;
        }

        private void Euro20_Click(object sender, RoutedEventArgs e)
        {
            geldeinwurf += 20;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
