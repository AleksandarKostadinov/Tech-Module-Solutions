namespace ProblemOne
{
    using System;
    using System.Collections.Generic;

    public class HornetWings
    {
        public static void Main()
        {
            var wingFlaps = int.Parse(Console.ReadLine());
            var distancePerThusentFlaps = decimal.Parse(Console.ReadLine());
            var endurance = int.Parse(Console.ReadLine());

            var distance = (wingFlaps / 1000m) * distancePerThusentFlaps;
            var restSeconds = (wingFlaps / endurance )* 5;
            var flySeconds = wingFlaps / 100m;

            var totalSeconds = restSeconds + flySeconds;

            Console.WriteLine($"{distance:F2} m.");
            Console.WriteLine(totalSeconds + " s.");
        }
    }
}
