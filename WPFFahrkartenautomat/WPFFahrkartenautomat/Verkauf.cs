using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.ComponentModel;

namespace WPFFahrkartenautomat
{
    //Class Verkauf: zur Laufzeit veränderliche Parameter zum Kauf eines oder mehrerer gleicher Tickets; Implementation Bezahlvorgang
    public class Verkauf : INotifyPropertyChanged
    {
        #region Felder
        private double _moneyin;
        private double _topay;
        private string _priceshow;
        private int _amount;
        private Ticket _ticket;
        #endregion

        CultureInfo culture = new CultureInfo("de-DE");
        public event PropertyChangedEventHandler PropertyChanged;

        #region Properties
        // Geldeinwurf
        public double Moneyin
        {
            get => default;
            set
            {
            }
        }

        // Anzeigewert des aktuellen Preises
        public string Priceshow
        {
            get => default;
            set
            {
                this.PriceEuro = _price.ToString("c", culture);
                this.ToPay = "Zu zahlen:\t\t" + this.PriceEuro;
            }
        }

        // Anzeigewert des noch zu bezahlenden Betrags
        public double Topay
        {
            get => default;
            set
            {
            }
        }

        public int Amount
        {
            get => default;
            set
            {
            }
        }

        public Ticket Ticket
        {
            get => default;
            set
            {
            }
        }
        #endregion

        public void Bezahlen()
        {
            double diff;
            string output;
            diff = this.Price - input;
            output = diff.ToString("c", culture);

            if (diff > 0)
            {
                this.ToPay = output.Insert(0, "Zu zahlen: \t\t");
            }
            else
            {
                this.ToPay = output.Insert(0, "Wechselgeld: \t\t");
            }
        }

        public void AusgebenWechselgeld()
        {
            throw new System.NotImplementedException();
        }
    }
}