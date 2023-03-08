namespace WebshopOpgave_AfshinAzadegan_
{
    internal class Order
    {
        public double Amount { get; set; }
        public double TotalPrice { get; set; }
        public DateTime Created { get; set; }
        public bool IsPaid { get; set; }

        public Product Product { get; set; }
        
    }
}
