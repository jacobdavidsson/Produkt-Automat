using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produkt_Automat
{
    internal abstract class VendingMachine
    {
        private static int count = 0;
        public string Name { get; set; }
        public string Desc { get; set; }
        public int Cost { get; set; }
        public static int Count { get { return count; } }

        public VendingMachine(string name, string desc, int cost)
        {
            this.Name = name;
            this.Desc = desc;
            this.Cost = cost;
            count++;
        }
    }
}
