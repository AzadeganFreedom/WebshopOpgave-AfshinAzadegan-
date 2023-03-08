namespace WebshopOpgave_AfshinAzadegan_
{
    internal class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhoneNumber { get; set; }

        public string UserName { get; set; }
        public string Password { get; set; }


        public List<Order> ShoppingBasket { get; set; }


        public Address DeliveryAddress { get; set; }
        public Address HomeAddress { get; set; }




        public void Login()
        {
            Console.WriteLine("Hello! \nDo you already have an account, or would you like to create an account?\n\n1: Sign in\n2: Create account\n\nq: Close application");
            string userChoice = Console.ReadLine();
            Console.Clear();

            while (true)
            {
                switch (userChoice)
                {
                    case "1":
                        Console.WriteLine("Please insert your username:");
                        UserName = Console.ReadLine();
                        Console.WriteLine("Please insert your password:");
                        Password = Console.ReadLine();
                        break;
                        
                    case "2":

                        break;

                    case "q":
                        Console.WriteLine("See you next time!");
                        Environment.Exit(0);
                        break;
                        default:
                        break;
                }
                
            }
        }
    }
}
