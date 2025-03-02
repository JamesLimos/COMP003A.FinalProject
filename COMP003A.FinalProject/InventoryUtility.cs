using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.FinalProject
{
    /// <summary>
    /// Class to display information about perishable and canned foods.
    /// </summary>
    public class InventoryUtility
    {
        /// <summary>
        /// method to describe perishable foods.
        /// </summary>
        /// <param name="name"></param>
        public static void DescribeItem(string name)
        {
            Console.WriteLine($"Foods that can spoil, decay, or become unsafe to consume if not properly refrigerated or frozen. For example: {name}");
        }
        /// <summary>
        /// method to describe canned foods.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="shelfLife"></param>
        public static void DescribeItem(string name, int shelfLife)
        {
            Console.WriteLine($"Shelf-stable food products packed in and sealed in a containers. For example: {name} {shelfLife} year shelf life");
        }
    }
}
