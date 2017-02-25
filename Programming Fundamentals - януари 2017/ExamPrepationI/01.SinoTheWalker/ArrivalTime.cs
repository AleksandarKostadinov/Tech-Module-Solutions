namespace _01.SinoTheWalker
{
    using System;
    using System.Globalization;
    using System.Numerics;

    class ArrivalTime
    {
        static void Main()
        {
            var startTime = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", CultureInfo.InvariantCulture);

            var steps = BigInteger.Parse(Console.ReadLine());
            var secondsForSteps = BigInteger.Parse(Console.ReadLine());

            BigInteger totalSeconds = steps * secondsForSteps;
            BigInteger seconds = totalSeconds % 60;
            BigInteger minutes = totalSeconds / 60;
            BigInteger hours = minutes / 60;
            hours %= 24;
            minutes %= 60;

            var arrivalTime = startTime.AddSeconds((double)seconds);
            arrivalTime = arrivalTime.AddMinutes((double)minutes);
            arrivalTime= arrivalTime.AddHours((double)hours);

            Console.WriteLine($"Time Arrival: {arrivalTime:HH:mm:ss}");
        }
    }
}
