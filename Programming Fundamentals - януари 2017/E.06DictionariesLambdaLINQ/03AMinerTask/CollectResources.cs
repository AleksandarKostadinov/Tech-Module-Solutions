namespace _03AMinerTask
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class CollectResources
    {
        static void Main()
        {
            var resource = Console.ReadLine();
            var resourceQuantity = new Dictionary<string, long>();

            while (resource != "stop")
            {
                var quantity = long.Parse(Console.ReadLine());

                if (!resourceQuantity.ContainsKey(resource))
                {
                    resourceQuantity[resource] = 0;
                }

                resourceQuantity[resource] += quantity;

                resource = Console.ReadLine();
            }

            foreach (var pair in resourceQuantity)
            {
                if (resourceQuantity.Count > 0)
                {

                }
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
