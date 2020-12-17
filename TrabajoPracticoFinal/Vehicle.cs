using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPracticoFinal
{
    public class Vehicle
    {
        private string domain;
        private string brand;
        private string model;
        private TypeVehicle typeVehicle;

        public string Domain
        {
            set
            {
                this.domain = value;
            }
            get
            {
                return this.domain;
            }
        }

        public string Brand
        {
            set
            {
                this.brand = value;
            }
            get
            {
                return this.brand;
            }
        }

        public string Model
        {
            set
            {
                this.model = value;
            }
            get
            {
                return this.model;
            }
        }

        public TypeVehicle TypeVehicle
        {
            set
            {
                this.typeVehicle = value;
            }
            get
            {
                return this.typeVehicle;
            }
        }
    }
}
