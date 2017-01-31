using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] firstArr = Console.ReadLine().ToCharArray();
            char[] secondArr = Console.ReadLine().ToCharArray();

            int lesserLength = Math.Min(firstArr.Length, secondArr.Length);
            bool equal = true;
            int lettersCount = 0;

            bool firstIsGreaterInAlphabet = true;
            for (int i = 0; i < lesserLength; i++)
            {
                if (firstArr[i] == secondArr[i])
                {
                    lettersCount++;
                    continue;
                }
                else if (secondArr[i] < firstArr[i])
                {
                    firstIsGreaterInAlphabet = false;
                    equal = false;
                    break;
                }
            }


            if (equal && lettersCount == lesserLength && lesserLength  == firstArr.Length)
            {
                PrintCharArrWithout(firstArr, ' ');
                PrintCharArrWithout(secondArr, ' ');
            }
            else if (equal && lettersCount == lesserLength && lesserLength == secondArr.Length)
            {
                PrintCharArrWithout(secondArr, ' ');
                PrintCharArrWithout(firstArr, ' ');
            }
            else if (firstIsGreaterInAlphabet)
            {
                PrintCharArrWithout(firstArr, ' ');
                PrintCharArrWithout(secondArr, ' ');
            }
            else
            {
                PrintCharArrWithout(secondArr, ' ');
                PrintCharArrWithout(firstArr, ' ');
            }
        }

        public static void PrintCharArrWithout(char[] arr, char separator)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != ' ')
                {
                    Console.Write(arr[i]);
                }
            }

            Console.WriteLine();
        }
    }
}
