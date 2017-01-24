using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            float meters = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());
            
            float totalHours = hours + minutes / 60.0f + seconds / 3600.0f;
            float kilometersPerHours = (meters / 1000.0f )/ totalHours;
            float meterPerSeconds = kilometersPerHours / 3.6f;
            float milesPerHour = kilometersPerHours / 1.609f;

            Console.WriteLine("{0}",meterPerSeconds);
            Console.WriteLine("{0}",kilometersPerHours);
            Console.WriteLine("{0}",milesPerHour);
        }
    }
}
