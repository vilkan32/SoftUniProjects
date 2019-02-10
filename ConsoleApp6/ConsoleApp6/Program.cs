using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
           
                int readconsole = int.Parse(Console.ReadLine());

            int intinput = 0;
            sbyte sbyteinput = 0;
            int sbytetransformation = 0;

            try
            {
                intinput = Convert.ToInt32(readconsole);
                sbyteinput = Convert.ToSByte(readconsole);
                sbytetransformation = Convert.ToInt32(sbyteinput);
            }
            catch (Exception)
            {

              
            }
            int readconsoletwo = int.Parse(Console.ReadLine());

            try
            {
                if (intinput > 0)
                {

                }
                else
                {
                    
                }
                if (intinput == sbyteinput)
                {
                    intinput = Convert.ToInt32(readconsoletwo);
                }
                
                sbyteinput = Convert.ToSByte(readconsoletwo);
               sbytetransformation = Convert.ToInt32(sbyteinput);
            }
            catch (Exception)
            {


            }

           

           long output = (10 * (long)intinput) + (4 * sbytetransformation);

            Console.WriteLine(output);



        }
    }
}
