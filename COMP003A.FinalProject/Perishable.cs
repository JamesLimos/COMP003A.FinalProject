using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.FinalProject
{
    internal class Perishable : Item
    {
        public Perishable(string name, int quantity)
        { 
            Name = name;
            Quantity = quantity;
        }

        public override void GetDetails()
        {
            
        }
    }
}
