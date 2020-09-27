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
        public Verkauf Actual = new Verkauf();


        public Ticketkauf()
        {
            InitializeComponent();
            this.DataContext = Actual;
        }

        public Ticketkauf(Ticket selticket) : this()
        {
            Actual.Ticket = selticket;
        }

        private void Cancel_Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Startseite());
        }


        #region Geldeinwurf
        private void Einwerfen_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            string euroin = btn.Name;
            Actual.Moneyin = (int)Enum.Parse(typeof(Geldwerte),euroin);
        }

        #endregion

        private void Amount_Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            string amchange = btn.Name;

            switch (amchange)
            {
                case "Mehr":
                    Actual.Amount += 1;
                    break;
                case "Weniger":
                    Actual.Amount -= 1;
                    break;
            }

            if(Actual.Amount > 1)
            {
                ThicknessConverter thkcon = new ThicknessConverter();
                Thickness th1 = (Thickness)thkcon.ConvertFromString("1");
                Weniger.Visibility = Visibility.Visible;
                Brd_Weniger.BorderThickness = th1;
            }
            else
            {
                ThicknessConverter thkcon = new ThicknessConverter();
                Thickness th0= (Thickness)thkcon.ConvertFromString("0");
                Weniger.Visibility = Visibility.Collapsed;
                Brd_Weniger.BorderThickness = th0;
            }
        }
    }
}
