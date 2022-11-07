using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produkt_Automat
{
    internal class Drinks : VendingMachine, iVendingMachine
    {
        public Drinks(string name, string description, int cost) : base(name, description, cost)
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

        public void Drink()
        {
            throw new NotImplementedException();
        }
    }
}
