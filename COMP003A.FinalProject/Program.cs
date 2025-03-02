using System.Runtime.CompilerServices;

namespace COMP003A.FinalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Item> items = new List<Item>();

            //Loop for the menu.
            while (true)
            {
                Console.WriteLine("Welcome to Inventory management system: ");
                Console.WriteLine("Please choice an option: ");
                Console.WriteLine("1. Add a Perishable Food.");
                Console.WriteLine("2. Add a Canned Food.");
                Console.WriteLine("3. Display Inventory.");
                Console.WriteLine("4. Describe Item");
                Console.WriteLine("4. Update Quanity.");
                Console.WriteLine("5. Delete an Item.");
                Console.WriteLine("6. Exit");
                Console.WriteLine("Your Choice: ");
                int choice = int.Parse(Console.ReadLine());
                
                // Switch to handle menu choice.
                switch (choice)
                {
                    // case to add perishable foods.
                    case 1:
                        Console.Write("Enter Name: ");
                        string perishableName = Console.ReadLine();
                        Console.Write("Enter Quantity: ");
                        int perishableQuantity = int.Parse(Console.ReadLine());
                        items.Add(new Perishable(perishableName, perishableQuantity));
                        break;
                    // case to add canned foods.
                    case 2:
                        Console.Write("Enter Name: ");
                        string cannedName = Console.ReadLine();
                        Console.Write("Enter Quantity: ");
                        int cannedQuantity = int.Parse(Console.ReadLine());
                        items.Add(new Canned(cannedName, cannedQuantity));
                        break;
                    // case to view inventory.
                    case 3:
                        Console.WriteLine("Displaying Inventory: ");
                        foreach (Item item in items)
                        {
                            item.GetDetails();
                        }
                        break;
                    // case to give describe perishable and canned foods.
                    case 4:
                        //Loop for case menu
                        bool isRunning = true;

                        while (isRunning)
                        {
                            Console.WriteLine("Menu");
                            Console.WriteLine("1. Describe Perishable items");
                            Console.WriteLine("2. Describe Canned Items");
                            Console.WriteLine("3. Exit");
                            int itemchoice = int.Parse(Console.ReadLine());

                            //switch to handle users choice.
                            switch (itemchoice)
                            {
                                // describes perishable foods.
                                case 1:
                                    Console.WriteLine("Perishable Foods");
                                    InventoryUtility.DescribeItem("Tomato");
                                    break;
                                // describes canned foods
                                case 2:
                                    Console.WriteLine("Canned Foods");
                                    InventoryUtility.DescribeItem("Soup", 2);
                                    break;
                                // exits the meni
                                case 3:
                                    isRunning = false;
                                    break;
                                // handles wrong inputs
                                default:
                                    Console.WriteLine("Invalid input. Please try again.");
                                    break;
                            }
                        }
                        break;
                    // case to update item quantity.
                    case 5:
                        Console.Write("Enter the item you want to update: ");
                        string itemName = Console.ReadLine();
                        int index = -1;
                        for (int i = 0; i < items.Count; i++)
                        {
                           if (items[i].Name == itemName)
                            {
                                index = i; 
                            }
                        }
                        if (index != -1)
                        {
                            Console.Write("Enter new quantity: ");
                            int itemQuantity = int.Parse(Console.ReadLine());
                            items[index].Quantity = itemQuantity;
                            Console.WriteLine("Succesfully Updated!");
                        }
                        else
                        {
                            Console.WriteLine("Item not found.");
                        }
                        break;
                    //  case to delete item from inventory.
                    case 6:
                        Console.Write("Enter the item you want to delete: ");
                        string itemDelete = Console.ReadLine();
                        for (int i = 0; i < items.Count; i++)
                        {
                            if (items[i].Name == itemDelete)
                            {
                                items.RemoveAt(i);
                                Console.WriteLine("Deleted Succesfully!");
                            }
                        }
                        break;
                    // case to exit program
                    case 7:
                        Console.WriteLine("Goodbye!");
                        return;
                        break;
                    // handles wrong inputs.
                    default:
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        break;
                }
            }
        }
    }
}
