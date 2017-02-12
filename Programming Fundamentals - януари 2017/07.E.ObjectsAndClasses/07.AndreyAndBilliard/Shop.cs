namespace _07.AndreyAndBilliard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Shop
    {
        static void Main()
        {
            var shopsItems = new Dictionary<string, double>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var itemData = Console.ReadLine()
                    .Split('-');

                var itemName = itemData[0];
                var itemPrice = double.Parse(itemData[1]);
                shopsItems[itemName] = itemPrice;
            }
            var shopingList = new List<Customer>();

            var line = Console.ReadLine();

            while (line != "end of clients")
            {
                var customerData = line
                    .Split("-,".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                var customerName = customerData[0];
                var itemName = customerData[1];
                var quantity = double.Parse(customerData[2]);

                if (!shopsItems.ContainsKey(itemName))
                {
                    line = Console.ReadLine();
                    continue;
                }

                var currentCustomer = new Customer();
                currentCustomer.Name = customerName;
                currentCustomer.Order = new Dictionary<string, double>();
                currentCustomer.Order[itemName] = quantity;

                if (shopingList.Any(c => c.Name == customerName))
                {
                    Customer existingCustomer = shopingList
                        .First(s => s.Name == customerName);

                    if (!existingCustomer.Order.ContainsKey(itemName))
                    {
                        existingCustomer.Order[itemName] = 0;
                    }

                    existingCustomer.Order[itemName] += quantity;
                }
                else
                {
                    shopingList.Add(currentCustomer);
                }
                
                line = Console.ReadLine();
            }
            

            foreach (var customer in shopingList)
            {
                foreach (var item in customer.Order)
                {
                    foreach (var product in shopsItems)
                    {
                        if (item.Key == product.Key)
                        {
                            customer.Bill += item.Value * product.Value;
                        }
                    }
                }
            }

            shopingList = shopingList
                .OrderBy(c => c.Name)
                .ThenBy(b => b.Bill)
                .ToList();

            foreach (var cust in shopingList)
            {
                Console.WriteLine(cust.Name);

                foreach (var puschase in cust.Order)
                {
                Console.WriteLine($"-- {puschase.Key} - {puschase.Value}");
                }

                Console.WriteLine($"Bill: {cust.Bill:f2}");
            }

            var totalBill = shopingList.Sum(d => d.Bill);
            Console.WriteLine($"Total bill: {totalBill:f2}");
        }
    }
}
