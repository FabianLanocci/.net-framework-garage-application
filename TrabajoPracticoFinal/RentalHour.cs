using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPracticoFinal
{
    public class RentalHour : Rental
    {
        private DateTime since;
        private DateTime until;

        public DateTime Since
        {
            set
            {
                this.since = value;
            }
            get
            {
                return this.since;
            }
        }

        public DateTime Until
        {
            set
            {
                this.until = value;
            }
            get
            {
                return this.until;
            }
        }

        public override double CalculateAmount()
        {
            TimeSpan totalTime = until - since;

            if(totalTime.Hours < 1)
            {
                
            }
            switch(Garage.Vehicle.TypeVehicle.Code)
            {
                case "Moto":
                    {
                        return totalTime.TotalHours * 40;
                    }
                case "Car":
                    {
                        return totalTime.TotalHours * 80;
                    }
                case "Pick Up":
                    {
                        return totalTime.TotalHours * 120;
                    }
                default:
                    {
                        return 0;
                    }
            }
        }
    }
}
