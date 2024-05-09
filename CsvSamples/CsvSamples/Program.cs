using System;

namespace CsvSamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductsDatabase.LoadFromCsv("Products.csv");

            foreach (Product p in ProductsDatabase.Products)
            {
                Console.WriteLine($"#{p.Id} - {p.Name}, u.m.: {p.UnitOfMeasure}, unit price: {p.UnitPrice}");
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to close ...");
            Console.ReadKey();
        }
    }
}
