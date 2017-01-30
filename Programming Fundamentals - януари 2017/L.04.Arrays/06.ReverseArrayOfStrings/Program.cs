using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strs = Console.ReadLine().Split();
            string[] reversedStrs = new string[strs.Length];

            for (int i = 0; i < strs.Length; i++)
            {
                reversedStrs[i] = strs[strs.Length - 1 - i];
                Console.Write( reversedStrs[i] + " ");
            }
        }
    }
}
