using System;
using System.Net.Http.Headers;

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var mouse = new Product(1, "mouse gamer", 216.90);

            mouse.Id = 99;

            Console.WriteLine(mouse.Id);
            Console.WriteLine(mouse.Name);
            Console.WriteLine(mouse.Price);
        }
    }

    struct Product
    {
        public Product(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public int Id;
        public string Name; 
        public double Price;

        public double PriceinDolar(Double dolar)
        {
            return Price * dolar;
        }
    }
}