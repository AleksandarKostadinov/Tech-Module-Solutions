using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MaxMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int max = GetMax(GetMax(firstNum, secondNum), thirdNum);
            Console.WriteLine(max);
        }

        public static int GetMax(int firstNum, int secondNum)
        {
            return firstNum > secondNum ? firstNum : secondNum;
        }
    }
}
