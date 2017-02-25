
namespace _03.RageQuit
{
    using System;
    using System.Linq;
    using System.Text;

    public class UniqueChars
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var currentSubsequence = new StringBuilder();
            var currentNum = new StringBuilder();
            var result = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                var currentChar = input[i];

                if ((currentChar < '0' || currentChar > '9') && currentNum.Length == 0)
                {
                    currentSubsequence.Append(currentChar);
                }
                else if ((currentChar < '0' || currentChar > '9') && currentNum.Length > 0)
                {
                    var number = int.Parse(currentNum.ToString());

                    for (int j = 0; j < number; j++)
                    {
                        result.Append(currentSubsequence.ToString().ToUpper());
                    }

                    currentNum.Clear();
                    currentSubsequence.Clear();
                    currentSubsequence.Append(currentChar);
                }
                else if (currentChar >= '0' && currentChar <= '9')
                {
                    currentNum.Append(currentChar);
                }

                if (i == input.Length - 1)
                {
                    var number = int.Parse(currentNum.ToString());

                    for (int j = 0; j < number; j++)
                    {
                        result.Append(currentSubsequence.ToString().ToUpper());
                    }
                }
            }

            Console.WriteLine($"Unique symbols used: {result.ToString().Distinct().Count()}");
            Console.WriteLine(result.ToString());
        }
    }
}
