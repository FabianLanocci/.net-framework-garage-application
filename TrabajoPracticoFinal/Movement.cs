using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPracticoFinal
{
    public class Movement
    {
        private string concept;
        private double amount;
        private DateTime date;  
        private bool itsIncome;
        private User user;
        private CashCount cashCount;

        public string Concept
        {
            set
            {
                this.concept = value;
            }
            get
            {
                return this.concept;
            }
        }

        public double Amount
        {
            set
            {
                this.amount = value;
            }
            get
            {
                return this.amount;
            }
        }

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

        public bool ItsIncome
        {
            set
            {
                this.itsIncome = value;
            }
            get
            {
                return this.itsIncome;
            }
        }

        public User User
        {
            set
            {
                this.user = value;
            }
            get
            {
                return this.user;
            }
        }

        public CashCount CashCount
        {
            set
            {
                this.cashCount = value;
            }
            get
            {
                return this.cashCount;
            }
        }
    }
}
