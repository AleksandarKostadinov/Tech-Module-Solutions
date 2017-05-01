namespace ProblemThree
{
    using System;
    using System.Linq;
    public class HornetAssault
    {
        public static void Main()
        {
            var beeshives = Console.ReadLine()
                .Trim()
                .Split(" \t".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();

            var hornets = Console.ReadLine()
                .Trim()
                .Split(" \t".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();

            var hornetsSumPower = hornets.Sum();

            for (int i = 0; i < beeshives.Count; i++)
            {
                if (hornets.Count == 0)
                {
                    break;
                }

                long beehiveCount = beeshives[i];

                beeshives[i] -= hornetsSumPower;

                if (beehiveCount >= hornetsSumPower)
                {
                    hornets.RemoveAt(0);
                    hornetsSumPower = hornets.Sum();
                }
            }


            if (beeshives.Any(bh => bh > 0))
            {
                Console.WriteLine(string.Join(" ", beeshives.Where(bh => bh > 0)));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
        }
    }
}
