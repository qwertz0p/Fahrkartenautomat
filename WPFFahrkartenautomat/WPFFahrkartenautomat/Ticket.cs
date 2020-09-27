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
        private int _price;
        private Areas2Price _area;
        #endregion

        #region Properties

        // Berliner Areal
        public Areas2Price Area
        {
            get => _area;
            set
            {
                _area = value;

                // Automatische Anpassung des Preises bei Zuweisung des Areals
                this.Price = (int)_area;
            }
        }
        // Basispreis des Tickets
        public int Price
        {
            get => _price;
            set
            {
                _price = value;

            }
        }


        #endregion

        #region Konstruktoren

        public Ticket() { }

        public Ticket(Areas2Price ticketarea)
        {
            this.Area = ticketarea;
        }
        #endregion Konstruktoren

        #region Methoden
        public void Print()
        {
            throw new System.NotImplementedException();
        }
        #endregion


    }
}
