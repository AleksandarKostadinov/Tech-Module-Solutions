using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string secondName = Console.ReadLine();
            byte age = byte.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            long persID = long.Parse(Console.ReadLine());
            int employeeNum = int.Parse(Console.ReadLine());
            Console.WriteLine("First name: " + firstName);
            Console.WriteLine("Last name: " + secondName);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Gender: " + gender);
            Console.WriteLine("Personal ID: " + persID);
            Console.WriteLine("Unique Employee number: " + employeeNum);


        }
    }
}
