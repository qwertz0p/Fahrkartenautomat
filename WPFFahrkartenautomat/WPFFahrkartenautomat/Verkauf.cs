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
        private double _topayint;
        private string _priceshow;
        private int _amount;
        private Ticket _ticket;
        private bool _fullypaid;


        private int[][] _insertcoins =
        {
            Enum.GetValues(typeof(Geldwerte)).Cast<Geldwerte>().Select(e => (int)e).ToArray(),
            new int[Enum.GetNames(typeof(Geldwerte)).Length]
        };

        private int[][] _outputcoins =
{
            Enum.GetValues(typeof(Geldwerte)).Cast<Geldwerte>().Select(e => (int)e).ToArray(),
            new int[Enum.GetNames(typeof(Geldwerte)).Length]
        };

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

                // Autoaktualisierung Priceshow
                this.AktualisierenPreis();

                // Autoaktualisierung Topay = Bezahlen
                Fullypaid = this.Bezahlen();
    
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
                this.AktualisierenPreis();

                // Autoaktualisierung von Topay
                Fullypaid = this.Bezahlen();
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
                // Wird bei Mengenveränderung (Amount set) oder Geldeinwurf (Moneyin set) ermittelt
                _fullypaid = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Fullypaid"));
            }
        }

        #endregion



        #region Konstruktoren
        public Verkauf(){}
        #endregion



        #region Methoden
        public bool Bezahlen()
        {
            // Aktualisierung: Noch zu Bezahlen
            _topayint = (double)((Amount * Ticket.Price) - Moneyin) / 100;
            if (_topayint > 0)
            {
                Topay = notpaid + _topayint.ToString("c", culture);
                return false;
            }
            else
            {
                Topay = paid + _topayint.ToString("c", culture);
                this.AusgebenWechselgeld();
                return true;

            }
        }

        public void AktualisierenPreis()
        {
            // Aktualisierung: Des zu zahlenden Gesamtpreises
            double tempPrice = (double)(this.Amount * this.Ticket.Price) / 100;
            this.Priceshow = tempPrice.ToString("c", culture);
        }

        public void EinwerfenMünze(int wert)
        {
            for (int i = 0; i < _insertcoins[0].Length; i++)
            {
                if(_insertcoins[0][i] == wert)
                {
                    _insertcoins[1][i] += 1;
                }
            }
        }
        public void AusgebenWechselgeld()
        {

            for (int i = Enum.GetNames(typeof(Geldwerte)).Length - 1; i >= 0; i--)
            {
                double temp = (double)(_topayint * 100) / _outputcoins[0][i];
                if(temp > 0)
                {
                    _outputcoins[1][i] = (int)Math.Truncate(temp);
                    _topayint -= Math.Truncate(temp) * _outputcoins[0][i];
                }
            }
        }
        #endregion

        public int[][] Insertcoins
        {
            get => default;
            set
            {
            }
        }

        public int[][] Outputcoins
        {
            get => default;
            set
            {
            }
        }
    }
}