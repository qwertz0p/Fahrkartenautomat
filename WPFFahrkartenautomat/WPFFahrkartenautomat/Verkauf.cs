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

        public string notpaid = "Zu zahlen:";
        public string paid = "Wechselgeld: ";



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

                // Auto: Aktualisierung des noch zu zahlenden Betrags
                double temp = ((this.Amount * this.Ticket.Price) - _moneyin) / 100;
                this.Topay = temp.ToString("c", culture);
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

                // Auto: Aktualisierung des Betrags der kompletten Ware
                double temp = (double)(this.Amount * this.Ticket.Price)/ 100;
                this.Priceshow = temp.ToString("c", culture);
            }
        }

        public Ticket Ticket
        {
            get => _ticket;
            set
            {
                _ticket = value;

                // Auto: es wird ein Ticket ausgewählt
                this.Amount = 1;
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
            //double diff;
            //string output;
            //diff = this.Price - input;
            //output = diff.ToString("c", culture);

            //if (diff > 0)
            //{
            //    this.ToPay = output.Insert(0, "Zu zahlen: \t\t");
            //}
            //else
            //{
            //    this.ToPay = output.Insert(0, "Wechselgeld: \t\t");
            //}
        }

        public void AusgebenWechselgeld()
        {
            throw new System.NotImplementedException();
        }
        #endregion
    }
}