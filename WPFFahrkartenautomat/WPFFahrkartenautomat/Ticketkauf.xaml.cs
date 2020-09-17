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

namespace WPFFahrkartenautomat
{
    /// <summary>
    /// Interaktionslogik für Ticketkauf.xaml
    /// </summary>
    public partial class Ticketkauf : Page
    {
        public Ticketkauf()
        {
            InitializeComponent();
        }
        double geldeinwurf = 0;

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
    }
}
