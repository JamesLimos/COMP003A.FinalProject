using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.FinalProject
{
    abstract class Item
    {
        private string _name;
        private int _quantity;

        public string Name
        {
            get {  return _name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty. Please provide a valid name.");
                }
                _name = value;
            }

        }

        public int Quantity
        {
            get { return _quantity; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Please enter a valid number.");
                }
                _quantity = value;
            }
        }

        public abstract void GetDetails();
    }
}
