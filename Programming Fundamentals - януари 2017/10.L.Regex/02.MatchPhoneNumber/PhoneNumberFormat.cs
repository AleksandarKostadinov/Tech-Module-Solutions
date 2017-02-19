namespace _02.MatchPhoneNumber
{
    using System.IO;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    class PhoneNumberFormat
    {
        static void Main()
        {
            var text = File.ReadAllText("Input.txt");

            var pattern = new Regex(@"(?<=\s|^)\+359(-| )2\1\d{3}\1\d{4}\b");

            var phoneNumbers = pattern.Matches(text);

            var result = new List<string>();

            foreach (Match phoneNumber in phoneNumbers)
            {
                result.Add(phoneNumber.Value);
            }

            File.WriteAllLines("Output.txt", result);
        }
    }
}
