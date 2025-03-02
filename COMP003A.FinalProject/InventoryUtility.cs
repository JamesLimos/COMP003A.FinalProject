using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.FinalProject
{
    public class InventoryUtility
    {
        public static void DescribeItem(string name)
        {
            Console.WriteLine($"Foods that can spoil, decay, or become unsafe to consume if not properly refrigerated or frozen. For example: {name}");
        }
        public static void DescribeItem(string name, int shelfLife)
        {
            Console.WriteLine($"Shelf-stable food products packed in and sealed in a containers. For example: {name} {shelfLife} year shelf life");
        }
    }
}
