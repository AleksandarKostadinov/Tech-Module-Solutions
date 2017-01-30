using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfDay = int.Parse(Console.ReadLine());

            PrintDayOfWeek(numOfDay);
        }

        public static void PrintDayOfWeek(int numOfDay)
        {
            var daysOfWeek = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            if (numOfDay >= 1 && numOfDay <=7 )
            {
                Console.WriteLine(daysOfWeek[numOfDay - 1]);
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}
