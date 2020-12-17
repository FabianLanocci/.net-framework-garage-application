using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPracticoFinal
{
    public abstract class Rental
    {
        private DateTime date;
        private Garage garage;

        public abstract double CalculateAmount();
     
        public DateTime Date
        {
            set
            {
                this.date = value;
            }
            get
            {
                return this.date;
            }
        }

        public Garage Garage
        {
            set
            {
                this.garage = value;
            }
            get
            {
                return this.garage;
            }
        }
    }
}
