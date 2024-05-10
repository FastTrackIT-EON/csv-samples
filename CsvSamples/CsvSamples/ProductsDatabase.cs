using CsvHelper;
using CsvHelper.Configuration;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace CsvSamples
{
    public static class ProductsDatabase
    {
        public static List<Product> Products { get; private set; } = new List<Product>();

        public static void SaveToCsv(string fileName)
        {
            IWriterConfiguration configuration = new CsvConfiguration(CultureInfo.InvariantCulture);
            using (var writer = new StreamWriter(fileName))
            {
                using (var csv = new CsvWriter(writer, configuration))
                {
                    csv.WriteRecords(Products);
                }
            }
        }

        public static void LoadFromCsv(string fileName)
        {
            IReaderConfiguration configuration = new CsvConfiguration(CultureInfo.InvariantCulture);
            using (var reader = new StreamReader(fileName))
            {
                using (var csv = new CsvReader(reader, configuration))
                {
                    IEnumerable<Product> records = csv.GetRecords<Product>();

                    ProductsDatabase.Products = new List<Product>(records);
                }
            }
            
        }
    }
}
