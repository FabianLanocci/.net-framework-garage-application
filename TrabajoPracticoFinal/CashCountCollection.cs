using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPracticoFinal
{
    public class CashCountCollection
    {
        List<CashCount> cashCountCollection = new List<CashCount>();

        public void Add(CashCount cashCount)
        {
            cashCountCollection.Add(cashCount);
        }

        public void Remove(CashCount cashCount)
        {
            cashCountCollection.Remove(cashCount);  
        }

        public List<CashCount> GetAll()
        {
            return this.cashCountCollection;
        }

        public void AddCashCountList(List<CashCount> cashCounts)
        {
            foreach(CashCount cashCount in cashCounts)
            {
                cashCountCollection.Add(cashCount);
            }
        }

        public void RemoveAll()
        {
            foreach(CashCount cashCount in cashCountCollection)
            {
                cashCountCollection.Remove(cashCount);
            }
        }
    }
}
