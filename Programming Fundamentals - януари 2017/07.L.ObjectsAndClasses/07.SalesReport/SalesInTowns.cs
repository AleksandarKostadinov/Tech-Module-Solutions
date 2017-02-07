namespace _07.SalesReport
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class SalesInTowns
    {
        public static void Main()
        {
            List<Sale> sales = ReadSales();

            var towns = sales
                .Select(t => t.Town)
                .Distinct()
                .OrderBy(w => w);

            foreach (var town in towns)
            {
                var moneyByTown = sales
                    .Where(s => s.Town == town)
                    .Select(t => t.Total)
                    .Sum();

                Console.WriteLine($"{town} -> {moneyByTown:f2}");
            }
        }

        public static List<Sale> ReadSales()
        {
            int n = int.Parse(Console.ReadLine());

            var sales = new List<Sale>();

            for (int i = 0; i < n; i++)
            {
                Sale currentSale = ReadSale();
                sales.Add(currentSale);
            }

            return sales;
        }

        public static Sale ReadSale()
        {
            var input = Console.ReadLine()
                .Split();

            Sale currentSale = new Sale
            {
                Town = input[0],
                Product = input[1],
                Price = decimal.Parse(input[2]),
                Quantity = decimal.Parse(input[3])
            };

            return currentSale;
        }
    }
}
