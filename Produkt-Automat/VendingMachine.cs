using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produkt_Automat
{
    internal abstract class VendingMachine
    {
        public string Name { get; set; }
        public string Desc { get; set; }
        public int Cost { get; set; }

        public VendingMachine(string name, string desc, int cost)
        {
            this.Name = name;
            this.Desc = desc;
            this.Cost = cost;
        }
    }
}
