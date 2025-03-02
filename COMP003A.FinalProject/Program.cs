using System.Runtime.CompilerServices;

namespace COMP003A.FinalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Item> items = new List<Item>();

            while (true)
            {
                Console.WriteLine("Welcome to Inventory management system: ");
                Console.WriteLine("Please choice an option: ");
                Console.WriteLine("1. Add a Perishable Food.");
                Console.WriteLine("2. Add a Canned Food.");
                Console.WriteLine("3. Display Inventory.");
                Console.WriteLine("4. Update Quanity.");
                Console.WriteLine("5. Delete an Item.");
                Console.WriteLine("6. Exit");
                Console.WriteLine("Your Choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Name: ");
                        string perishableName = Console.ReadLine();
                        Console.Write("Enter Quantity: ");
                        int perishableQuantity = int.Parse(Console.ReadLine());
                        items.Add(new Perishable(perishableName, perishableQuantity));
                        break;
                    case 2:
                        Console.Write("Enter Name: ");
                        string cannedName = Console.ReadLine();
                        Console.Write("Enter Quantity: ");
                        int cannedQuantity = int.Parse(Console.ReadLine());
                        items.Add(new Canned(cannedName, cannedQuantity));
                        break;
                    case 3:
                        Console.WriteLine("Displaying Inventory: ");
                        foreach (Item item in items)
                        {
                            item.GetDetails();
                        }
                        break;
                        break;
                    case 4:
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
                    case 5:
                        Console.Write("Enter the item tou want to delete: ");
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
                    case 6:
                        Console.WriteLine("Goodbye!");
                        return;
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        break;
                }
            }
        }
    }
}
