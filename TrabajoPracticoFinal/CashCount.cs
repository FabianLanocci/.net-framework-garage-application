using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPracticoFinal
{
    public class CashCount
    {
        private DateTime date;
        private User user;

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
        public override string ToString()
        {
            return date + " " + user.UserName;
        }
    }
}
