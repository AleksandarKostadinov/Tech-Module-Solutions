using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            a ^= b;
            b ^= a;
            a ^= b;

            Console.WriteLine("Before:\r\na = {0}\r\nb = {1}",b , a);
            Console.WriteLine("After:\r\na = {0}\r\nb = {1}",a , b);
        }
    }
}
