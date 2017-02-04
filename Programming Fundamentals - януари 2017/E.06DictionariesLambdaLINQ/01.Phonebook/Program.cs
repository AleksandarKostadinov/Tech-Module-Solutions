using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var tokens = Console.ReadLine()
                .Split();
            var contacts = new Dictionary<string, string>();

            while (tokens[0] != "END")
            {
                var command = tokens[0];
                var name = tokens[1];

                if (command == "A")
                {
                    var phoneNumber = tokens[2];
                    contacts[name] = phoneNumber;
                }
                else if (command == "S")
                {
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

                tokens = Console.ReadLine()
                    .Split();
            }
        }
    }
}
