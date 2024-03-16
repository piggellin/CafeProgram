namespace CafeProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu cafeMenu = Menu.Instance;
            cafeMenu.SortMenu();
            cafeMenu.PrintMenu();

            BeverageFactory beverageFactory = new BeverageFactory();

            List<IBeverage> orderedBeverages = new List<IBeverage>();
            while (true)
            {
                Console.WriteLine("\nEnter what you like to order (when you want to place the order, write 'done'):");
                string userInput = Console.ReadLine().Trim();


                if (string.Equals(userInput, "done", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                try
                {
                    IBeverage beverage = beverageFactory.CreateBeverage(userInput);
                    orderedBeverages.Add(beverage);
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Invalid beverage. Please choose from the menu.");
                }
            }

            Order order = new Order();
            foreach (var beverage in orderedBeverages)
            {
                order.AddBeverage(beverage);
            }

            Cashier cashier = new Cashier();
            cashier.PlaceOrder(order);

            Console.WriteLine("Thank you for your order! Your beverages are ready.");

            Console.ReadLine();
        }
    }
}
