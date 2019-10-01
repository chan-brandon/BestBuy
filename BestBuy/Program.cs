using System;

namespace BestBuy
{
    class Program
    {
        static void Main(string[] args)
        {

            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            Console.WriteLine(alphabet);

            Product nintendo = new Product();

            nintendo.Name = "Nintendo Lite";
            nintendo.Price = 200d;

            Console.WriteLine($"The new {nintendo.Name} costs ${nintendo.Price} and ${nintendo.PriceWithTax()} with tax included.");
        }
    }
}
