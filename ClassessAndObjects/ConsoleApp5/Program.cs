using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {

            string firstdate = Console.ReadLine();
            string seconddate = Console.ReadLine();
            string format = "dd-MM-yyyy";
            DateTime FirstDate = DateTime.ParseExact(firstdate, format, System.Globalization.CultureInfo.InvariantCulture);
            DateTime[] NonWorkingDays = new DateTime[11];
            string format1 = "dd-MM";
            NonWorkingDays[0] = DateTime.ParseExact("01-01", format1, System.Globalization.CultureInfo.InvariantCulture);
            NonWorkingDays[1] = DateTime.ParseExact("03-03", format1, System.Globalization.CultureInfo.InvariantCulture);
            NonWorkingDays[2] = DateTime.ParseExact("01-05", format1, System.Globalization.CultureInfo.InvariantCulture);
            NonWorkingDays[3] = DateTime.ParseExact("06-05", format1, System.Globalization.CultureInfo.InvariantCulture);
            NonWorkingDays[4] = DateTime.ParseExact("24-05", format1, System.Globalization.CultureInfo.InvariantCulture);
            NonWorkingDays[5] = DateTime.ParseExact("06-09", format1, System.Globalization.CultureInfo.InvariantCulture);
            NonWorkingDays[6] = DateTime.ParseExact("22-09", format1, System.Globalization.CultureInfo.InvariantCulture);
            NonWorkingDays[7] = DateTime.ParseExact("01-11", format1, System.Globalization.CultureInfo.InvariantCulture);
            NonWorkingDays[8] = DateTime.ParseExact("24-12", format1, System.Globalization.CultureInfo.InvariantCulture);
            NonWorkingDays[9] = DateTime.ParseExact("25-12", format1, System.Globalization.CultureInfo.InvariantCulture);
            NonWorkingDays[10] = DateTime.ParseExact("26-12", format1, System.Globalization.CultureInfo.InvariantCulture);
            DateTime SecondDate = DateTime.ParseExact(seconddate, format, System.Globalization.CultureInfo.InvariantCulture);
            int workingdays = 0;
            for (DateTime i = FirstDate; i <= SecondDate; i = i.AddDays(01))
            {

                int internalcounter = 0;
                if (i.DayOfWeek == DayOfWeek.Sunday || i.DayOfWeek == DayOfWeek.Saturday)
                {
                    continue;
                }

                for (int x = 0; x < NonWorkingDays.Length; x++)
                {
                    if (i.Day == NonWorkingDays[x].Day && i.Month == NonWorkingDays[x].Month)
                    {
                        internalcounter++;
                        break;
                       
                    }
                }

                if (internalcounter > 0)
                {

                }
                else
                {
                    workingdays++;
                }
                
            }

            Console.WriteLine(workingdays);

        }
    }
}
