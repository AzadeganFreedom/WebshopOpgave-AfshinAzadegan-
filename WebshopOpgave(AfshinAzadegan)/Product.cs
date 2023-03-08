using System.Security.Cryptography.X509Certificates;

namespace WebshopOpgave_AfshinAzadegan_
{
    enum ProductType { Guitar = 1, Bass, Amp, Strings, Miscellaneous }
    internal class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Stock { get; set; }
        public ProductType ProductType { get; set; }
        public double Price { get; set; }

        string valuta = "kr";



        public Product() { }
        public Product(int productId, ProductType productType, string productName, double price, int stock)
        {
            ProductId = productId;
            ProductType = productType;
            ProductName = productName;
            Price = price;
            Stock = stock;
        }

        public void ChooseProducts()
        {
            Console.WriteLine("What would you like to browse?: \n\n");
            Console.WriteLine("1: {0}\n2: {1}\n3: {2}\n4: {3}\n5: {4}\n\nEnter: Return to main menu", ProductType.Guitar, ProductType.Bass, ProductType.Amp, ProductType.Strings, ProductType.Miscellaneous);
            string userChoice = Console.ReadLine();
            Console.Clear();

            switch (userChoice)
            {
                case "1":
                    Console.WriteLine("Category: {0}\n", ProductType.Guitar);
                    foreach (var guitar1 in Data.guitarProducts)
                    {
                        Console.WriteLine(guitar1.ProductId + "\t" + guitar1.ProductName + "| " + guitar1.Price + valuta);
                    }
                    
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case "2":
                    Console.WriteLine("Category: {0}\n", ProductType.Bass);
                    foreach (var bass1 in Data.bassProducts)
                    {
                        Console.WriteLine(bass1.ProductId + "\t" + bass1.ProductName + "| " + bass1.Price + valuta);
                    }
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case "3":
                    Console.WriteLine("Category: {0}\n", ProductType.Amp);
                    foreach (var amp1 in Data.ampProducts)
                    {
                        Console.WriteLine(amp1.ProductId + "\t" + amp1.ProductName + "| " + amp1.Price + valuta);
                    }
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case "4":
                    Console.WriteLine("Category: {0}\n", ProductType.Strings);
                    foreach (var string1 in Data.stringProducts)
                    {
                        Console.WriteLine(string1.ProductId + "\t" + string1.ProductName + "| " + string1.Price + valuta);
                    }
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case "5":
                    Console.WriteLine("Category: {0}\n", ProductType.Miscellaneous);
                    foreach (var misc1 in Data.miscellaneousProducts)
                    {
                        Console.WriteLine(misc1.ProductId + "\t" + misc1.ProductName + "| " + misc1.Price + valuta);
                    }
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case "":

                    break;
                default: return;
            }

        }

    }




}
