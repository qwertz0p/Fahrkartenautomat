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
    // Class Ticket: Aufnahme von zur Laufzeit unveränderlichen Eigenschaften des ausgewählten Fahrscheins
    public class Ticket
    {
        #region Felder
        private double _price;
        private Areas _area;
        #endregion
        
        #region Properties
        // Basispreis des Tickets
        public double Price
        {
            get => _price;
            set
            {
                _price = value;

            }
        }

        // Berliner Areal
        public Areas Area
        {
            get => _area;
            set
            {
                _area = value;
            }
        }

        #endregion

        #region Konstruktoren

        public Ticket() { }

        public Ticket(Areas ticketarea, double ticketprice)
        {
            this.Area = ticketarea;
            this.Price = ticketprice;
        }
        #endregion Konstruktoren

        public void Print()
        {
            throw new System.NotImplementedException();
        }


    }
}
