using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PrintingTriangle
{
    class TriangleOfNumbers
    {
        static void Main(string[] args)
        {
            int parameter = int.Parse(Console.ReadLine());

            for (int i = 1; i < parameter; i++)
            {
                PrintLine(i);
            }

            PrintLine(parameter);

            for (int i = parameter -1; i > 0; i--)
            {
                PrintLine(i);
            }
        }

        public static void PrintLine(int lineLenght)
        {
            for (int i = 1; i <= lineLenght; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
        }
    }
}
