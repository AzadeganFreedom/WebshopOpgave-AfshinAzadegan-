namespace WebshopOpgave_AfshinAzadegan_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            new Data().AddProducts();

            //Customer customer = new Customer();
            //customer.Login();

            Menu menu = new Menu();
            menu.Customer = new Customer() { CustomerFirstName = "John", CustomerLastName = "Doe"};
            while (true)
            {
                menu.MainMenu();
            }
        }
    }
}