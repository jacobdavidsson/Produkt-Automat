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
            Console.WriteLine("Du köpte {0} för {1} kronor", this.Name, this.Cost);
        }

        public void Description()
        {
            Console.WriteLine(this.Desc);
        }

        public void Use()
        {
            Console.WriteLine("Du åt {0}", this.Name);
        }
    }
}
