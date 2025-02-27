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
        }
    }
}
