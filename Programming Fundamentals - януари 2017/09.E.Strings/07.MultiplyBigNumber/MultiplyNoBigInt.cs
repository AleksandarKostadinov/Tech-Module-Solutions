namespace _07.MultiplyBigNumber
{
    using System;

    public class MultiplyNoBigInt
    {
        public static void Main()
        {
            var number = Console.ReadLine().TrimStart('0');
            var multiplier = Console.ReadLine().TrimStart('0');

            if (multiplier == string.Empty)
            {
                multiplier = "0";
            }
            if (number == string.Empty)
            {
                number = "0";
            }
            
            string product = GetProduct(number, multiplier);

            Console.WriteLine(product);
        }

        public static string GetProduct(string number, string multiplier)
        {
            var product = string.Empty;
            var carried = 0;
            var multiplierNum = int.Parse(multiplier);

            if (true)
            {

            }

            for (int i = 0; i < number.Length; i++)
            {
                var currentDigit = int.Parse(number[number.Length - 1 - i].ToString());

                var currentProduct = currentDigit * multiplierNum + carried;

                var currentResultDigit = currentProduct % 10;

                product = currentResultDigit + product;

                carried = currentProduct / 10;
            }
            

            if (carried > 0)
            {
                product = carried + product;
            }

            product= product.TrimStart('0');

            if (product == string.Empty)
            {
                product = "0";
            }

            return product;
        }
    }
}
