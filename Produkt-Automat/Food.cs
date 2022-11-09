using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produkt_Automat
{
    internal class Food : VendingMachine, iVendingMachine
    {
        public Food(string name, string desc, int cost) : base(name, desc, cost)
        {
        }

        public void Buy()
        {
            throw new NotImplementedException();
        }

        public void Description()
        {
            throw new NotImplementedException();
        }

        public void Use()
        {
            throw new NotImplementedException();
        }
    }
}
