using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.PrintPartOfASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int finish = int.Parse(Console.ReadLine());

            for (char currentChr = (char)start; currentChr <= finish; currentChr++)
            {
                Console.Write(currentChr + " ");
            }
        }
    }
}
