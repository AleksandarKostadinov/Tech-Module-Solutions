namespace _01.DayOfWeek
{
    using System;
    using System.Globalization;
    public class Day
    {
        public static void Main()
        {
            var dateStr = Console.ReadLine();
            var date = DateTime.ParseExact(
                dateStr, "d-M-yyyy"
                , CultureInfo.InvariantCulture);

            Console.WriteLine(date.DayOfWeek);

        }
    }
}
