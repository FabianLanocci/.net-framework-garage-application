using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPracticoFinal
{
    public class RentalCollection
    {
        List<Rental> rentalCollection = new List<Rental>();

        public void Add(Rental rental)
        {
            rentalCollection.Add(rental);
        }

        public void Remove(Rental rental)
        {
            rentalCollection.Remove(rental);
        }

        public List<Rental> GetAll()
        {
            return this.rentalCollection;
        }

        public Rental SearchRentByNumber(int number)
        {

            foreach (Rental rental in rentalCollection)
            {
                if (rental.Garage.Number == number)
                {
                    return rental;
                }
            }
            return null;
        }

        public Rental searchmmmh(int numerito)
        {
            foreach(Rental rental in rentalCollection)
            {
                if(rental is RentalMonth)
                {
                    if(rental.Garage.Number == numerito)
                    {
                        return rental as RentalMonth;
                    }
                }
                else
                {
                    if(rental.Garage.Number == numerito)
                    {
                        return rental as RentalHour; 
                    }
                }
            }
            return null;
        }

        public RentalHour SearchRentHourByNumber(int number)
        {
            foreach (RentalHour rental in rentalCollection)
            {
                if (rental.Garage.Number == number)
                {
                    return rental;
                }
            }
            return null;
        }

        public RentalMonth SearchRentMonthByNumber(int number)
        {
            foreach (RentalMonth rental in rentalCollection)
            {
                if (rental.Garage.Number == number)
                {
                    return rental;
                }
            }
            return null;
        }

        public void AddRentalsList(List<Rental> rentals)
        {
            foreach (Rental rental in rentals)
            {
                rentalCollection.Add(rental);
            }
        }

        public void RemoveAll()
        {
            foreach (Rental rental in rentalCollection)
            {
                rentalCollection.Remove(rental);
            }
        }

        public bool IfDomainExists(string domain)
        {
            foreach (Rental rental in rentalCollection)
            {
                if(rental.Garage.Vehicle.Domain == domain && rental.Garage.State == false)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
