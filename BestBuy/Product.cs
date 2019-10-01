using System;
namespace BestBuy
{
    public class Product : IProduct
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public double PriceWithTax()
        {
            return Price * 1.1;
        }
    }
}
