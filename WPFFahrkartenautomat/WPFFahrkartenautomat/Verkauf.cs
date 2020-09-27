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
        CultureInfo culture = new CultureInfo("de-DE");

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, e);
        }

        public string notpaid = "Zu zahlen:\t";
        public string paid = "Wechselgeld:\t";



        #region Felder
        private int _moneyin;
        private string _topay;
        private string _priceshow;
        private int _amount;
        private Ticket _ticket;
        private bool _fullypaid;
        #endregion



        #region Properties
        // Geldeinwurf
        public int Moneyin
        {
            get => _moneyin;
            set
            {
                _moneyin += value;
                OnPropertyChanged(new PropertyChangedEventArgs("Moneyin"));

                // Autoaktualisierung von Topay und Priceshow
                this.AktualisierenWerte();
    
            }
        }

        // Anzeigewert des aktuellen Preises
        public string Priceshow
        {
            get => _priceshow;
            set
            {
                _priceshow = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Priceshow"));
            }
        }

        // Anzeigewert des noch zu bezahlenden Betrags
        public string Topay
        {
            get => _topay;
            set
            {
                _topay = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Topay"));
            }
        }

        public int Amount
        {
            get => _amount;
            set
            {
                _amount = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Amount"));

                // Autoaktualisierung von Topay und Priceshow
                this.AktualisierenWerte();
            }
        }

        public Ticket Ticket
        {
            get => _ticket;
            set
            {
                _ticket = value;

                // Auto: Initialisierung nur einmal zu Beginn; es wird ein Ticket ausgewählt
                this.Amount = 1;
                _moneyin = 0;
                this.Moneyin = 0;
            }
        }

        public bool Fullypaid
        {
            get => _fullypaid;
            set
            {
                _fullypaid = value;
            }
        }
        #endregion



        #region Konstruktoren
        public Verkauf(){}
        #endregion



        #region Methoden
        public void Bezahlen()
        {

        }

        public void AktualisierenWerte()
        {
            // Aktualisierung: Noch zu Bezahlen
            double tempTopay = (double)((Amount * Ticket.Price) - Moneyin) / 100;
            if (tempTopay > 0)
            {
                Topay = notpaid + tempTopay.ToString("c", culture);
            }
            else
            {
                Topay = paid + tempTopay.ToString("c", culture);
            }

            // Aktualisierung: Des zu zahlenden Gesamtpreises
            double tempPrice = (double)(this.Amount * this.Ticket.Price) / 100;
            this.Priceshow = tempPrice.ToString("c", culture);


        }

        public void AusgebenWechselgeld()
        {
            throw new System.NotImplementedException();
        }
        #endregion
    }
}