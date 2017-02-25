using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var field = new int[n];

            var indexes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < n; i++)
            {
                if (indexes.Contains(i))
                {
                    field[i] = 1;
                }
            }

            var line = Console.ReadLine();

            while (line != "end")
            {
                var tokens = line
                .Split();

                var ladybugIndex = long.Parse(tokens[0]);
                var direction = tokens[1];
                var flyLenght = long.Parse(tokens[2]);

                if (ladybugIndex >=0 && ladybugIndex <field.Length)
                {
                    if (field[ladybugIndex] == 0)
                    {
                        line = Console.ReadLine();
                        continue;
                    }

                    field[ladybugIndex] = 0;

                    if (direction == "left")
                    {
                        flyLenght = flyLenght * -1;
                    }

                    var indexToLand = ladybugIndex + flyLenght;

                    while (indexToLand >= 0 && indexToLand < field.Length)
                    {
                        if (field[indexToLand] == 1)
                        {
                            indexToLand += flyLenght;
                        }
                        else
                        {
                            field[indexToLand] = 1;
                            break;
                        }
                    }
                } 

                line = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}
