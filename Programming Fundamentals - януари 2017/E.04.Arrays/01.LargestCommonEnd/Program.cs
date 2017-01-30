using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstWordArr = Console.ReadLine().Split(' ');
            string[] secondWordArr = Console.ReadLine().Split(' ');

            int leftEqualsCount = 0;
            int rightEqualsCount = 0;

            int lengthOfShorterArr = Math.Min(firstWordArr.Length, secondWordArr.Length);

            for (int i = 0; i < lengthOfShorterArr; i++)
            {
                if (firstWordArr[i] == secondWordArr[i])
                {
                    leftEqualsCount++;
                }
                if (firstWordArr[firstWordArr.Length - 1 -i] == secondWordArr[secondWordArr.Length - 1 - i])
                {
                    rightEqualsCount++;
                }
            }
            Console.WriteLine(Math.Max(leftEqualsCount, rightEqualsCount));
        }
    }
}
