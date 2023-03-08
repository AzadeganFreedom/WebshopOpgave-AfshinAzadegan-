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

        public Product() { }
        public Product(int productId, ProductType productType, string productName, double price, int stock)
        {
            ProductId = productId;
            ProductType = productType;
            ProductName = productName;
            Price = price;
            Stock = stock;
        }



    }




}
