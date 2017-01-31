using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> line = Console.ReadLine().Split('|').ToList();

            for (int i = line.Count - 1; i >= 0; i--)
            {
                List<int> currentList = line[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToList();

                Console.Write(string.Join(" ", currentList));
                Console.Write(" ");
            }
        }
    }
}
