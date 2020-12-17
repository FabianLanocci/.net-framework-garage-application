using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPracticoFinal
{
    public class MovementCollection
    {
        List<Movement> movementCollection = new List<Movement>();

        public void Add(Movement movement)
        {
            movementCollection.Add(movement);
        }

        public void Remove(Movement movement)
        {
            movementCollection.Remove(movement);
        }

        public void RemoveAll()
        {
            foreach(Movement movement in movementCollection)
            {
                movementCollection.Remove(movement);
            }
        }
        public List<Movement> GetAll()
        {
            return this.movementCollection;
        }

        public List<Movement> GetItsIncome()
        {
            List<Movement> movementIncomeCollection = new List<Movement>();

            foreach (Movement movement in movementCollection)
            {
                if(movement.ItsIncome == true && movement.CashCount == null)
                {
                    movementIncomeCollection.Add(movement);
                }
            }

            return movementIncomeCollection;
        }

        public List<Movement> GetItsOutcome()
        {
            List<Movement> movementOutcomeCollection = new List<Movement>();

            foreach (Movement movement in movementCollection)
            {
                if (movement.ItsIncome == false && movement.CashCount == null)
                {
                    movementOutcomeCollection.Add(movement);
                }
            }

            return movementOutcomeCollection;
        }

        public void AddMovementsList(List<Movement> movements)
        {
            foreach(Movement movement in movements)
            {
                movementCollection.Add(movement);
            }
        }
    }
}
