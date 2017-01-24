using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long numOfPictures = long.Parse(Console.ReadLine());
            int secondsToFilter = int.Parse(Console.ReadLine());
            int percentFiltered = int.Parse(Console.ReadLine());
            int secondsToUpload = int.Parse(Console.ReadLine());

            long filteredPictures = (int)Math.Ceiling((double)numOfPictures * percentFiltered * 0.01);
            long totalSeconds = numOfPictures * secondsToFilter + filteredPictures * secondsToUpload;

            long seconds = totalSeconds;
            long days = seconds / (60 * 60 * 24);
            seconds = seconds % (60 * 60 * 24);
            long hours = seconds / (60 * 60);
            seconds = seconds % (60 * 60);
            long minutes = seconds / 60;
            seconds %= 60;

            Console.WriteLine("{0:#0}:{1:00}:{2:00}:{3:00}",days, hours, minutes , seconds);

        }
    }
}
