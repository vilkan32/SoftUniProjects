using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhottoGallery
{
    class Program
    {
        static void Main(string[] args)
        {

            int name = int.Parse(Console.ReadLine());

            int day = int.Parse(Console.ReadLine());

            int month = int.Parse(Console.ReadLine());

            int year = int.Parse(Console.ReadLine());

            int hour = int.Parse(Console.ReadLine());

            int minute = int.Parse(Console.ReadLine());

            double size =  double.Parse(Console.ReadLine());

            int orient1 = int.Parse(Console.ReadLine());

            int orient2 = int.Parse(Console.ReadLine());

            double sizenumber = size;


            Console.WriteLine("Name: DSC_{0:d4}.jpg",name);
            Console.WriteLine("Date Taken: {0:d2}/{1:d2}/{2:d4} {3:d2}:{4:d2}",day,month,year,hour,minute);

            //. 950 bytes = 950B, 500000 bytes = 500KB, 1500000 bytes = 1.5MB).

            if (size < 1000)
            {
                Console.WriteLine("Size: {0}B",size);
            }
            else if (size > 1000 && size < 1000000)
            {
                sizenumber = size / 1000;
                Console.WriteLine("Size: {0}KB", Math.Round(sizenumber, 0));
            }
            else if (size > 1000000)
            {
                sizenumber = size / 1000000;
                Console.WriteLine("Size: {0}MB", Math.Round(sizenumber,1));
            }

            if (orient1 == orient2)
            {
                Console.WriteLine("Resolution: {0}x{1} (square)", orient1,orient2);
            }
            else if (orient1 > orient2)
            {
                Console.WriteLine("Resolution: {0}x{1} (landscape)", orient1, orient2);
            }
            else if (orient1 < orient2)
            {
                Console.WriteLine("Resolution: {0}x{1} (portrait)", orient1, orient2);
            }



        }
    }
}
