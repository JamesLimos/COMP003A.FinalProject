using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.FinalProject
{
    /// <summary>
    /// This abstract class represents Items in an inventory.
    /// </summary>
    abstract class Item
    {
        /// <summary>
        /// private fields for name and quantity
        /// </summary>
        private string _name;
        private int _quantity;
        /// <summary>
        /// gpublic field for the name of the item.
        /// </summary>
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
        /// <summary>
        /// public field for the quanity of the item.
        /// </summary>
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
        /// <summary>
        /// abstract method to display the details of the item.
        /// </summary>
        public abstract void GetDetails();
    }
}
