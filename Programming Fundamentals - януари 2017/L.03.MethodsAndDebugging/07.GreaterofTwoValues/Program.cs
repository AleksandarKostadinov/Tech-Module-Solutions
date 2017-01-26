using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.GreaterofTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string variable = Console.ReadLine();

            switch (variable)
            {
                case "int":
                    int firstInt = int.Parse(Console.ReadLine());
                    int secondInt = int.Parse(Console.ReadLine());
                    int max = GetMax(firstInt, secondInt);
                    Console.WriteLine(max);
                    break;
                case "char":
                    char firstChar = char.Parse(Console.ReadLine());
                    char secondChar = char.Parse(Console.ReadLine());
                    char maxChar = (char)GetMax((int)firstChar, (int)secondChar);
                    Console.WriteLine(maxChar);
                    break;
                case "string":
                    string firstStr = Console.ReadLine();
                    string secondStr = Console.ReadLine();
                    string maxStr = GetMax(firstStr, secondStr);
                    Console.WriteLine(maxStr);
                    break;
                default:
                    break;
            }
        }

        public static string GetMax(string firstStr, string secondStr)
        {
            if (firstStr.CompareTo(secondStr) > 0)
            {
                return firstStr;
            }
            else
            {
                return secondStr;
            }
        }

        public static int GetMax(int first, int second)
        {
            if (second > first)
            {
                return second;
            }
            else
            {
                return first;
            }
        }
    }
}
