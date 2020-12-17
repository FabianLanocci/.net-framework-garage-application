using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPracticoFinal
{
    public class TypeVehicle
    {
        private string code;
        private string description;

        public string Code
        {
            set
            {
                this.code = value;
            }
            get
            {
                return this.code;
            }
        }

        public string Description
        {
            set
            {
                this.description = value;
            }
            get
            {
                return this.description;
            }
        }
    }
}
