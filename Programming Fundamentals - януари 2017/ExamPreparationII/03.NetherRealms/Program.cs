using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            var demodNames = Console.ReadLine()
                .Split(',')
                .Select(d => d.Trim())
                .ToArray();

            var demons = new List<Demon>();

            for (int i = 0; i < demodNames.Length; i++)
            {
                var currenName = demodNames[i];

                int currentHealt = 0;

                for (int j = 0; j < currenName.Length; j++)
                {
                    var currentSymbol = currenName[j];
                    if (!(currentSymbol >= '0' && currentSymbol <= '9')
                        && currentSymbol != '+' && currentSymbol != '-' 
                        && currentSymbol != '*' && currentSymbol != '/' && currentSymbol != '.')
                    {
                        currentHealt += currentSymbol;
                    }
                }

                var currentDamage = 0d;
                var currentNumber = string.Empty;

                for (int d = 0; d < currenName.Length; d++)
                {
                    var currentSymbol = currenName[d];

                    if ((currentSymbol >= '0' && currentSymbol <= '9')
                        || currentSymbol == '+' || currentSymbol == '-' || currentSymbol == '.')
                    {
                        currentNumber += currentSymbol;// add symbol

                        if ( d == currenName.Length - 1)
                        {
                            var parsedNum = double.Parse(currentNumber);
                            currentDamage += parsedNum;
                            currentNumber = string.Empty;
                        }
                    }
                    else if (currentNumber != string.Empty)
                    {
                        var parsedNum = double.Parse(currentNumber);
                        currentDamage += parsedNum;
                        currentNumber = string.Empty;
                        // parse, add, empty number
                    }

                    if (currentNumber.Length > 1 &&( currentNumber.EndsWith("+") || currentNumber.EndsWith("-")))
                    {
                        currentNumber = currentNumber.Substring(0, currentNumber.Length - 1);
                        var num = double.Parse(currentNumber);
                        currentDamage += num;
                        currentNumber = string.Empty;
                        currentNumber += currentSymbol;
                    }
                    // to do if numbers are not separated by letter
                }

                for (int k = 0; k < currenName.Length; k++)
                {
                    if (currenName[k] == '*')
                    {
                        currentDamage *= 2;
                    }
                    else if (currenName[k] == '/')
                    {
                        currentDamage /= 2;
                    }
                }

                var currentDemon = new Demon
                {
                    Name = currenName,
                    Health = currentHealt,
                    Damage = currentDamage
                };

                demons.Add(currentDemon);
            }

            foreach (var demon in demons.OrderBy(d => d.Name))
            {
                Console.WriteLine($"{demon.Name} - {demon.Health} health, {demon.Damage:F2} damage");
            } 
        }
    }

    class Demon
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public double Damage { get; set; }
    } 
}
