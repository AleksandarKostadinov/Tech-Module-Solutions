namespace _02.PhonebookUpgrade
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class ContactsUpgrade
    {
        static void Main()
        {
            var tokens = Console.ReadLine()
               .Split();
            var contacts = new SortedDictionary<string, string>();

            while (tokens[0] != "END")
            {
                var command = tokens[0];

                if (command == "A")
                {
                    var name = tokens[1];
                    var phoneNumber = tokens[2];
                    contacts[name] = phoneNumber;
                }
                else if (command == "S")
                {
                    var name = tokens[1];

                    if (contacts.ContainsKey(name))
                    {
                        var phoneNumber = contacts[name];
                        Console.WriteLine($"{name} -> {phoneNumber}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }
                else if (command == "ListAll")
                {
                    foreach (var contact in contacts)
                    {
                        Console.WriteLine($"{contact.Key} -> {contact.Value}");
                    }
                }

                tokens = Console.ReadLine()
                    .Split();
            }
        }
    }
}
