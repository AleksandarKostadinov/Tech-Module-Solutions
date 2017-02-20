namespace _01.ExtactEmails
{
    using System;
    using System.Text.RegularExpressions;

    class Emails
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();

            var pattern = new Regex(@"\b(?<!\.|-|_)[a-zA-Z0-9]+[\w-_\.]+[a-zA-Z0-9]+@([a-z-]+\.)+[a-zA-Z-]+\b");

            var emails = pattern.Matches(text);

            foreach (Match email in emails)
            {
                Console.WriteLine(email.Value);
            }
        }
    }
}
