using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.FinalProject
{
    internal class Canned : Item
    {
        public Canned(string name, int quantity) 
        {
            Name = name;
            Quantity = quantity;
        }

        public override void GetDetails()
        {
          
        }
    }
}
