namespace _01.SweetDessert
{
    using System;

    public class Cooking
    {
        public static void Main()
        {
            var amountOfCash = decimal.Parse(Console.ReadLine());
            var numberOfGuests = decimal.Parse(Console.ReadLine());
            var bananaPrice = decimal.Parse(Console.ReadLine());
            var eggPrice = decimal.Parse(Console.ReadLine());
            var berryPrice = decimal.Parse(Console.ReadLine());

            var setsOfSweets = Math.Ceiling(numberOfGuests / 6);

            var totalPrice = setsOfSweets * (2 * bananaPrice + 4 * eggPrice + 0.2m * berryPrice);

            if (amountOfCash >= totalPrice)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {totalPrice:F2}lv.");
            }
            else
            {
                var neededMoney = totalPrice - amountOfCash;
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {neededMoney:F2}lv more.");
            }
        }
    }
}
