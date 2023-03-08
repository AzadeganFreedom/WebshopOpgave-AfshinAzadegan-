namespace WebshopOpgave_AfshinAzadegan_
{
    internal class Menu
    {

        public void MainMenu()
        {
            Console.WriteLine("* * * Welcome to Freedom Music! * * *\n\nWhat would you like to do?\n\n");
            Console.WriteLine("1: Buy products\n2: Check current order\n3: Check previous orders\n\nq: Close Application");
            string userChoice = Console.ReadLine();
            Console.Clear();

            switch(userChoice)
            {
                case "1":
                    new Product().ChooseProducts();                       
                    break;
                case "2":

                    break;
                case "3":

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
