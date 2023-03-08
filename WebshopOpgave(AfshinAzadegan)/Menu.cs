namespace WebshopOpgave_AfshinAzadegan_
{
    internal class Menu
    {
        private string valuta = "kr.";
        private Customer customer;
        public Customer Customer { get { return customer; } set { customer = value; } }


        //Main menu. The first thing the customer sees when starting the application
        public void MainMenu()
        {
            Console.WriteLine("* * * Welcome to Freedom Music! * * *\n\nWhat would you like to do?\n\n");
            Console.WriteLine("1: Buy products\n2: Check shopping basket\n\nq: Close Application");
            string userChoice = Console.ReadLine();
            Console.Clear();

            //Multiple choice main menu. press the necessary key, followed by the "enter" button to proceed
            switch (userChoice)
            {
                //To browse the products
                case "1":
                    ChooseProducts();
                    break;

                //To check the shopping basket
                case "2":
                    customer.CheckShoppingBasket();
                    break;

                //To close the application
                case "q":
                    Console.WriteLine("See you next time!");
                    Environment.Exit(0);
                    break;
                default:
                    break;

            }
        }

        public void ChooseProducts()
        {
            Console.WriteLine("What would you like to browse?: \n\n");
            Console.WriteLine($"1: {ProductType.Guitar}\n2: {ProductType.Bass}\n3: {ProductType.Amp}\n4: {ProductType.Strings}\n5: {ProductType.Miscellaneous}\n\nEnter: Return to main menu");
            string userChoice = Console.ReadLine();
            Console.Clear();

            switch (userChoice)
            {
                //Guitar
                case "1":
                    Console.WriteLine("Category: {0}\n", ProductType.Guitar);
                    foreach (var guitar1 in Data.guitarProducts)
                    {
                        //Shows every guitar product
                        Console.WriteLine(guitar1.ProductId + "\t" + guitar1.ProductName + "| " + guitar1.Price + valuta);
                    }

                    int guitarChoice = int.Parse(Console.ReadLine());
                    foreach (var guitar1 in Data.guitarProducts)
                    {
                        if (guitarChoice == guitar1.ProductId) customer.ShoppingBasket.Add(new Order() { Amount = 1, Created = DateTime.Now, IsPaid = false, Product = guitar1 });
                    }

                    Console.WriteLine("The item is added to your shopping basket");
                    Console.ReadKey();
                    Console.Clear();
                    break;

                //Bass
                case "2":
                    Console.WriteLine("Category: {0}\n", ProductType.Bass);
                    foreach (var bass1 in Data.bassProducts)
                    {
                        Console.WriteLine(bass1.ProductId + "\t" + bass1.ProductName + "| " + bass1.Price + valuta);
                    }

                    int bassChoice = int.Parse(Console.ReadLine());
                    foreach (var bass1 in Data.bassProducts)
                    {
                        if (bassChoice == bass1.ProductId)
                        {
                            customer.ShoppingBasket.Add(new Order() { Amount = 1, Created = DateTime.Now, IsPaid = false, Product = bass1 });                    
                        }
                    }
                    Console.WriteLine("The item is added to your shopping basket");
                    Console.ReadKey();
                    Console.Clear();
                    break;

                //Amp
                case "3":
                    Console.WriteLine("Category: {0}\n", ProductType.Amp);
                    foreach (var amp1 in Data.ampProducts)
                    {
                        Console.WriteLine(amp1.ProductId + "\t" + amp1.ProductName + "| " + amp1.Price + valuta);
                    }

                    int ampChoice = int.Parse(Console.ReadLine());
                    foreach (var amp1 in Data.bassProducts)
                    {
                        if (ampChoice == amp1.ProductId)
                        {
                            customer.ShoppingBasket.Add(new Order() { Amount = 1, Created = DateTime.Now, IsPaid = false, Product = amp1 });
                        }
                    }
                    Console.WriteLine("The item is added to your shopping basket");
                    Console.ReadKey();
                    Console.Clear();
                    break;

                //Strings
                case "4":
                    Console.WriteLine("Category: {0}\n", ProductType.Strings);
                    foreach (var string1 in Data.stringProducts)
                    {
                        Console.WriteLine(string1.ProductId + "\t" + string1.ProductName + "| " + string1.Price + valuta);
                    }
                    int stringChoice = int.Parse(Console.ReadLine());
                    foreach (var string1 in Data.bassProducts)
                    {
                        if (stringChoice == string1.ProductId)
                        {
                            customer.ShoppingBasket.Add(new Order() { Amount = 1, Created = DateTime.Now, IsPaid = false, Product = string1 });
                        }
                    }
                    Console.WriteLine("The item is added to your shopping basket");
                    Console.ReadKey();
                    Console.Clear();
                    break;

                //Miscellaneous
                case "5":
                    Console.WriteLine("Category: {0}\n", ProductType.Miscellaneous);
                    foreach (var misc1 in Data.miscellaneousProducts)
                    {
                        Console.WriteLine(misc1.ProductId + "\t" + misc1.ProductName + "| " + misc1.Price + valuta);
                    }
                    int miscChoice = int.Parse(Console.ReadLine());
                    foreach (var misc1 in Data.miscellaneousProducts)
                    {
                        if (miscChoice == misc1.ProductId)
                        {
                            customer.ShoppingBasket.Add(new Order() { Amount = 1, Created = DateTime.Now, IsPaid = false, Product = misc1 });
                        }
                    }
                    Console.WriteLine("The item is added to your shopping basket");
                    Console.ReadKey();
                    Console.Clear();
                    break;

                //Return back to the main menu
                case "":

                    break;
                default: return;
            }

        }



    }
}
