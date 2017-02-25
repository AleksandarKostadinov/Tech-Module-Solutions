namespace _01.CharityMarathon
{
    using System;

    class FootRace
    {
        static void Main()
        {
            var daysToRun = decimal.Parse(Console.ReadLine());
            var runnersToParticipate = decimal.Parse(Console.ReadLine());
            var lapPerRunner = decimal.Parse(Console.ReadLine());
            var lenghtOfTrack = decimal.Parse(Console.ReadLine());
            var capacityOfTrack = decimal.Parse(Console.ReadLine());
            var moneyPerKilometer = decimal.Parse(Console.ReadLine());

            var runnersToRun = runnersToParticipate;
            var maximumCapacity = capacityOfTrack * daysToRun;

            if (runnersToRun > maximumCapacity)
            {
                runnersToRun = maximumCapacity;
            }

            var kilometers = runnersToRun * lenghtOfTrack * lapPerRunner / 1000m;

            var rasedForMarathon = kilometers * moneyPerKilometer;

            Console.WriteLine($"Money raised: {rasedForMarathon:f2}");
        }
    }
}
