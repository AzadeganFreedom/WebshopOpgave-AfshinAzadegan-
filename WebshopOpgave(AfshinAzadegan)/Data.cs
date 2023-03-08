namespace WebshopOpgave_AfshinAzadegan_
{
    internal class Data
    {
        public static List<Product> guitarProducts = new(), bassProducts = new(), ampProducts = new(), stringProducts = new(), miscellaneousProducts = new();
        

        public void AddProducts()
        {
            Product guitar1 = new Product(1, ProductType.Guitar, "Harley Benton ST-62CC MN Shell Pink", 1139, 10);
            Product guitar2 = new Product(2, ProductType.Guitar, "Solar Guitars A1.6AAN Aged Natural Matte", 9799, 5);
            Product guitar3 = new Product(3, ProductType.Guitar, "Fender Tash Sultana Stratocaster TC", 9790, 3);
            guitarProducts = new List<Product>();
            guitarProducts.Add(guitar1);
            guitarProducts.Add(guitar2);
            guitarProducts.Add(guitar3);

            Product bass1 = new Product(1, ProductType.Bass, "Marcus Miller V7 Alder-4 TS 2nd Gen", 4111, 3);
            Product bass2 = new Product(2, ProductType.Bass, "Cort B4 Element Open Pore Black", 3999, 7);
            Product bass3 = new Product(3, ProductType.Bass, "Warwick RB Corvette $$ 5 FL NB TS", 6999, 1);
            bassProducts = new List<Product>();
            bassProducts.Add(bass1);
            bassProducts.Add(bass2);
            bassProducts.Add(bass3);

            Product amp1 = new Product(1, ProductType.Amp, "Marshall Studio Vintage SV20C Combo", 7222, 5);
            Product amp2 = new Product(2, ProductType.Amp, "Blackstar HT-5R MkII", 4333, 12);
            Product amp3 = new Product(3, ProductType.Amp, "Orange TremLord 30 Orange", 11099, 10);
            ampProducts = new List<Product>();
            ampProducts.Add(amp1);
            ampProducts.Add(amp2);
            ampProducts.Add(amp3);

            Product string1 = new Product(1, ProductType.Strings, "Daddario EPS170-5", 289, 20);
            Product string2 = new Product(2, ProductType.Strings, "Ernie Ball 2223", 44, 68);
            Product string3 = new Product(3, ProductType.Strings, "Ernie Ball 3222 3 Pack", 132, 23);
            stringProducts = new List<Product>();
            stringProducts.Add(string1);
            stringProducts.Add(string2);
            stringProducts.Add(string3);

            Product misc1 = new Product(1, ProductType.Miscellaneous, "the sssnake IPP1030", 26, 100);
            Product misc2 = new Product(2, ProductType.Miscellaneous, "Millenium GS-2001 E", 59, 50);
            Product misc3 = new Product(3, ProductType.Miscellaneous, "Ernie Ball E-Guitar Strap TQ EB4098", 188, 43);
            miscellaneousProducts = new List<Product>();
            miscellaneousProducts.Add(misc1);
            miscellaneousProducts.Add(misc2);
            miscellaneousProducts.Add(misc3);
        }

    }
}
