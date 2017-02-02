namespace _05.BombNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Detonation
    {
        static void Main()
        {
            var sequence = ReadListOfInt();
            //var sequence = new List<long>() { 7, 1, 7, 1 };

            var bombAndPower = ReadListOfInt();

            var bomb = bombAndPower[0];
            var power = bombAndPower[1];

            Detonate(bomb, power, sequence);

            long sum = GetSumListInt(sequence);

            Console.WriteLine(sum);
        }

        public static void Detonate(long bomb, long power, List<long> sequence)
        {
            for (long i = 0; i < sequence.Count;)
            {
                long currentNum = sequence[(int)i];

                if (currentNum == bomb)
                {
                    long beforeZero = 0;
                    if (i - power < 0)
                    {
                        beforeZero = Math.Abs(i - power);
                    }
                    long countOfDistroyed = power * 2 + 1 - beforeZero;
                    long counter = 0;
                    for (long j = i - power; counter < countOfDistroyed;)
                    {
                        if (i - power < 0)
                        {
                            j = 0;
                        }
                        if (j < sequence.Count)
                        {
                            sequence.RemoveAt((int)j);
                            counter++;

                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else
                {
                    i++;
                }
            }
        }

        public static long GetSumListInt(List<long> numbers)
        {
            long sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }

        public static List<long> ReadListOfInt()
        {
            List<long> numbers = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();

            return numbers;
        }
    }
}
