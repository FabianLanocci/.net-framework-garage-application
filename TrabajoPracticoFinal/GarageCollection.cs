using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPracticoFinal
{
    public class GarageCollection
    {
        List<Garage> garageCollection = new List<Garage>(35);

        public void Add(Garage garage)
        {
            garageCollection.Add(garage);
        }

        public void Remove(Garage garage)
        {
            garageCollection.Remove(garage);
        }

        public List<Garage> GetAll()
        {
            return this.garageCollection;
        }

        public int GetFree()
        {
            int amount = 35;

            foreach (Garage g in garageCollection)
                {
                    if(g.State == false)
                    {
                        amount -= 1;
                    }
                }
            return amount;
        }

        public int GetOcuppied()
        {
            int amount = 0;

            foreach (Garage g in garageCollection)
            {
                if (g.State == false)
                {
                    amount += 1;
                }
            }
            return amount;
        }

        public Garage SearchByDomain(string domain)
        {
            foreach(Garage garage in garageCollection)
            {
                if(garage.Vehicle.Domain == domain)
                {
                    return garage;
                }
            }
            return null;
        }


        public bool SearchByDomainBool(string domain)
        {
            foreach (Garage garage in garageCollection)
            {
                if (garage.Vehicle.Domain == domain)
                {
                    return true;
                }
            }
            return false;
        }

        public Garage SearchByNumber(int number)
        {
            foreach (Garage garage in garageCollection)
            {
                if(garage.Number == number)
                {
                    return garage;
                }
            }
            return null;
        }

        
    }
}
