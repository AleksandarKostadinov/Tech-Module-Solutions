using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.TriplesOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int paremeter = int.Parse(Console.ReadLine());
            for (int i = 0; i < paremeter; i++)
            {
                for (int j = 0; j < paremeter; j++)
                {
                    for (int k = 0; k < paremeter; k++)
                    {
                        Console.WriteLine("{0}{1}{2}",(char)('a' + i), (char)('a' + j), (char)('a' + k));
                    }
                }
            }
        }
    }
}
