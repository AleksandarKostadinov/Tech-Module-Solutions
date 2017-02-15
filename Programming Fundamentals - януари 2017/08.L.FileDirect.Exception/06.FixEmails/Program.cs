namespace _06.FixEmails
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    class Program
    {
        static void Main()
        {
            var lines = File.ReadAllLines("Input.txt");
            var emailContacts = new Dictionary<string, string>();

            for (int i = 0; i < lines.Length; i += 2)
            {
                var name = lines[i];
                var email = lines[i + 1];

                if (!email.ToLower().EndsWith("us") && !email.ToLower().EndsWith("uk"))
                {
                    emailContacts[name] = email;
                }
            }

            var output = new List<string>();

            foreach (var contact in emailContacts)
            {
                var name = contact.Key;
                var email = contact.Value;
                output.Add($"{name} -> {email}");
            }

            File.WriteAllLines("Output.txt", output);
        }
    }
}
