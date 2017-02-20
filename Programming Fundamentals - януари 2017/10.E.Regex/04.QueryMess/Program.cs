namespace _04.QueryMess
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();

            while (line != "END")
            {
                var pairs = line
                    .Split('&');

                var fieldValue = new Dictionary<string, List<string>>();
                var pattern = @"(([\+]*)([%][2][0])+[\+]*)+|([\+])+";
                var regex = new Regex(pattern);

                for (int i = 0; i < pairs.Length; i++)
                {
                    var currentPair = pairs[i];
                    var fieldAndValueInfo = currentPair.Split('=');
                    var fieldInfo = fieldAndValueInfo[0].Split('?');
                    var field = fieldInfo[fieldInfo.Length - 1];
                    var value = fieldAndValueInfo[1];

                    var fixedField = Regex.Replace(field, pattern, " ");
                    var fixedValue = Regex.Replace(value, pattern, " ");
                    fixedField = fixedField.Trim();
                    if (!fieldValue.ContainsKey(fixedField))
                    {
                        fieldValue[fixedField] = new List<string>();
                    }
                    fieldValue[fixedField].Add(fixedValue.Trim());
                }

                foreach (var pair in fieldValue)
                {
                    Console.Write(pair.Key + "=[" + string.Join(", ",pair.Value) + "]");
                }
                Console.WriteLine();

                line = Console.ReadLine();
            }
        }
    }
}
