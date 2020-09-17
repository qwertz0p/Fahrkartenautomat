using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFFahrkartenautomat
{
    class Ticket
    {
        private double _price;
        private Areas _area;

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
