using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SoftuniCoffeeOrders
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            decimal totalPrice = 0m;

            for (int i = 0; i < n; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                DateTime currentDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                long capsulesCount = long.Parse(Console.ReadLine());

                

                int daysInMount = DateTime.DaysInMonth(currentDate.Year, currentDate.Month);

                decimal price = ((daysInMount * capsulesCount) * pricePerCapsule);

                Console.WriteLine($"The price for the coffee is: ${price:F2}");

                totalPrice += price;
            }

            Console.WriteLine($"Total: ${totalPrice:F2}");
        }
    }
}
