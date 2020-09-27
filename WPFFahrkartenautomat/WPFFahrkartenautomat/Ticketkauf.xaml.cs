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


        //Hier wiederholt sich Code!! Es muss also umdesignt werden :-)

        #region Geldeinwurf
        private void Cent10_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Cent20_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Cent50_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Euro1_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Euro2_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Euro5_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Euro10_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Euro20_Click(object sender, RoutedEventArgs e)
        {
        }

        #endregion
    }
}
