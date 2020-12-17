using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPracticoFinal
{
    public class Garage 
    {
        private int number;
        private string ubication;
        private bool state;
        private Vehicle vehicle;

        public int Number
        {
            set
            {
                this.number = value;
            }
            get
            {
                return this.number;
            }
        }

        public string Ubication
        {
            set
            {
                this.ubication = value;
            }
            get
            {
                return this.ubication;
            }
        }

        public bool State
        {

            set
            {
                this.state = value;
            }
            get
            {
                return this.state;
            }
        }

        public Vehicle Vehicle
        {
            set
            {
                this.vehicle = value;
            }
            get
            {
                return this.vehicle;
            }
        }
    }
}
