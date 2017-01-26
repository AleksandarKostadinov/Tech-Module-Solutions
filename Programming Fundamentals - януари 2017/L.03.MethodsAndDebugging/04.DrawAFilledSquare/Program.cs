using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.DrawAFilledSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int parameter = int.Parse(Console.ReadLine());

            PrintFilledSquear(parameter);
        }

        public static void PrintFilledSquear(int parameter)
        {
            PrintTop(parameter);

            for (int i = 0; i < parameter - 2; i++)
            {
                PrintMiddle(parameter);
            }

            PrintBottom(parameter);
        }

        public static void PrintTop(int parameter)
        {
            Console.WriteLine(new string('-', parameter * 2));
        }

        public static void PrintMiddle(int parameter)
        {
            Console.Write('-');
            for (int i = 0; i < parameter - 1 ; i++)
            {
                Console.Write("\\/");
            }

            Console.WriteLine('-');
        }

        public static void PrintBottom(int parameter)
        {
            PrintTop(parameter);
        }
    }
}
