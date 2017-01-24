using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.DifferentIntegersSize
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            bool fits = false;
            string fitsIn = "";
            try
            {
                sbyte sBNum = sbyte.Parse(number);
                fits = true;
                fitsIn += "\r\n* sbyte";
            }
            catch (Exception)
            {
            }
            try
            {
                byte bNum = byte.Parse(number);
                fits = true;
                fitsIn += "\r\n* byte";
            }
            catch (Exception)
            {
            }
            try
            {
                short sNum = short.Parse(number);
                fits = true;
                fitsIn += "\r\n* short";
            }
            catch (Exception)
            {
            }
            try
            {
                ushort uSNum = ushort.Parse(number);
                fits = true;
                fitsIn += "\r\n* ushort";
            }
            catch (Exception)
            {
            }
            try
            {
                int iNum = int.Parse(number);
                fits = true;
                fitsIn += "\r\n* int";
            }
            catch (Exception)
            {
            }
            try
            {
                uint sNum = uint.Parse(number);
                fits = true;
                fitsIn += "\r\n* uint";
            }
            catch (Exception)
            {
            }
            try
            {
                long lNum = long.Parse(number);
                fits = true;
                fitsIn += "\r\n* long";
            }
            catch (Exception)
            {
            }
            if (fits)
            {
                Console.WriteLine($"{number} can fit in:" + fitsIn);
            }
            else
            {
                Console.Write(number + " ");
                Console.WriteLine("can't fit in any type");
            }

        }
    }
}
