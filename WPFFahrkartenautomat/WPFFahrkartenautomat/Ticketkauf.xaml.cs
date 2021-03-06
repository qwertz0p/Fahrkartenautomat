﻿using System;
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
        ThicknessConverter thkcon = new ThicknessConverter();


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
            Actual.AbbrechenVorgang();
            Ausgabe.Visibility = Visibility.Visible;
            Brd_Fertig.Visibility = Visibility.Visible;
            Brd_Einwurf.Visibility = Visibility.Collapsed;
            
        }

        private void Fertig_Button_Click(object sender, RoutedEventArgs e)
        {
            Actual.AbbrechenVorgang();
            this.NavigationService.Navigate(new Startseite());
        }

        #region Geldeinwurf
        private void Einwerfen_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            string euroin = btn.Name;
            Actual.Moneyin = (int)Enum.Parse(typeof(Geldwerte),euroin);

            if (Actual.Fullypaid)
            {
                Brd_Einwurf.Visibility = Visibility.Collapsed;
                Cancel.Visibility = Visibility.Collapsed;
                Mehr.Visibility = Visibility.Collapsed;
                Weniger.Visibility = Visibility.Collapsed;
                Thickness th0 = (Thickness)thkcon.ConvertFromString("0");
                Brd_Cancel.BorderThickness = th0;
                Brd_Mehr.BorderThickness = th0;
                Brd_Weniger.BorderThickness = th0;
                Ausgabe.Visibility = Visibility.Visible;

                Brd_Ticket.Visibility = Visibility.Visible;
            }
        }

        private void Ticket_Button_Click(object sender, RoutedEventArgs e)
        {
            Actual.Ticket.Print();
            this.NavigationService.Navigate(new Startseite());
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
                Thickness th1 = (Thickness)thkcon.ConvertFromString("1");
                Weniger.Visibility = Visibility.Visible;
                Brd_Weniger.BorderThickness = th1;
            }
            else
            {
                Thickness th0= (Thickness)thkcon.ConvertFromString("0");
                Weniger.Visibility = Visibility.Collapsed;
                Brd_Weniger.BorderThickness = th0;
            }
        }
    }
}
