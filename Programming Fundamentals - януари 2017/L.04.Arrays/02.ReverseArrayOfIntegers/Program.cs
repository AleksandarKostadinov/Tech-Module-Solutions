using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ReverseArrayOfIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengthOfArr = int.Parse(Console.ReadLine());
            int[] arr= GetArrayOfInts(lengthOfArr);

            Console.WriteLine(string.Join(" ", arr.Reverse()));
        }

        public static int[] GetArrayOfInts(int lengthOfArr)
        {
            int[] arr = new int[lengthOfArr];
            for (int currentElement = 0; currentElement < lengthOfArr; currentElement++)
            {
                arr[currentElement] = int.Parse(Console.ReadLine());
            }

            return arr;
        }
    }
}
