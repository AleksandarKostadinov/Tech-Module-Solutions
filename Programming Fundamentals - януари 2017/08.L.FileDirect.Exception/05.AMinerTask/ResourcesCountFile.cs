using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.AMinerTask
{
    class ResourcesCountFile
    {
        static void Main()
        {
            var resources = File.ReadAllLines("Input.txt");
            var resourceQuantity = new Dictionary<string, long>();

           for(int i = 0; i < resources.Length; i += 2)
            {
                var quantity = long.Parse(resources[i + 1]);

                if (!resourceQuantity.ContainsKey(resources[i]))
                {
                    resourceQuantity[resources[i]] = 0;
                }

                resourceQuantity[resources[i]] += quantity;
            }

            var output = new List<string>();

            foreach (var pair in resourceQuantity)
            {
                output.Add($"{pair.Key} -> {pair.Value}");
            }

            File.WriteAllLines("output.txt", output);
        }
    }
}
