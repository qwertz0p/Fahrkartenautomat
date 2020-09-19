using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace WPFFahrkartenautomat
{
    public class Ticket
    {
        private double _price;
        private Areas _area;
        private string _priceeuro;

        public Ticket() { }
        public Ticket(Areas ticketarea, double ticketprice)
        {
            this.Area = ticketarea;
            this.Price = ticketprice;
            string temp = (_price * 100).ToString();
            _priceeuro = temp.Insert(temp.Length - 2, ",");
        }

        public double Price
        {
            get => _price;
            set
            {
                _price = value;
               
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

        public Areas Area
        {
            get => _area;
            set
            {
                _area = value;
            }
        }
    }
}
