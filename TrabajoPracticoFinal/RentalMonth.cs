using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPracticoFinal
{
    public class RentalMonth : Rental
    {
        private string holder;
        private DateTime dueDate;

        public string Holder
        {
            set
            {
                this.holder = value;
            }
            get
            {
                return this.holder;
            }
        }

        public DateTime DueDate
        {
            set
            {
                this.dueDate = value;
            }
            get
            {
                return this.dueDate;
            }
        }

        public override double CalculateAmount()
        {
            DateTime totalTime = dueDate.AddMonths(-DateTime.Now.Month);
            return totalTime.Month * 1500;
        }
    }
}
