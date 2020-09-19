using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Globalization;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WPFFahrkartenautomat
{
    public class Ticket : INotifyPropertyChanged
    {
        private double _price;
        private Areas _area;
        private string _priceeuro;
        private string _topay;
        CultureInfo culture = new CultureInfo("de-DE");
        public event PropertyChangedEventHandler PropertyChanged;

        public Ticket() { }
        public Ticket(Areas ticketarea, double ticketprice)
        {
            this.Area = ticketarea;
            this.Price = ticketprice;
        }

        public double Price
        {
            get => _price;
            set
            {
                _price = value;
                this.PriceEuro = _price.ToString("c", culture);
                this.ToPay = "Zu zahlen:\t\t" + this.PriceEuro;

            }
        }

        public string PriceEuro
        {
            get => _priceeuro;
            set
            {
                _priceeuro = value;
            }
        }

        public string ToPay
        {
            get => _topay;
            set
            {
                _topay = value;
                OnPropertyChanged(new PropertyChangedEventArgs("ToPay"));
            }
        }

        public Areas Area
        {
            get => _area;
            set
            {
                _area = value;
            }
        }

        protected void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, e);
        }

        public void TicketBezahlen(double input)
        {
            double diff;
            string output;
            diff = this.Price - input;
            output = diff.ToString("c", culture);

            if(diff > 0)
            {
                this.ToPay = output.Insert(0, "Zu zahlen: \t\t");
            }
            else
            {
                this.ToPay =  output.Insert(0, "Wechselgeld: \t\t");
            }
        }
    }
}
