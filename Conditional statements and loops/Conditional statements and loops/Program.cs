using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_statements_and_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string months = Console.ReadLine();

            double nights = double.Parse(Console.ReadLine());

           double studio = 0;
            double Double = 0;

            double suite = 0;

        

            if (months == "May" || months == "October")
            {
                if (nights> 7)
                {
                    studio = 50;
                    studio = studio - studio * 0.05;
                }
                else 
                {
                    studio = 50;
                }

             
            
                Double = 65;
                suite = 75;

            }
            else if (months == "June" || months == "September")
            {
                suite = 82;
                studio = 60;
               
                if (nights > 14)
                {
                    Double = 72;

                    Double = Double - Double * 0.1;
                }
                else
                {
                    Double = 72;
                }
                


            }
            else if (months == "July" || months == "August" || months == "December")
            {
                studio = 68;
                Double = 77;
                
                if (nights > 14)
                {
                    suite = 89;
                    suite = suite - suite * 0.15;
                }
                else
                {
                    suite = 89;
                }

               

            }

            if (months == "September" || months == "October" && nights > 7)
            {
                Console.WriteLine("Studio: {0:f2} lv.\nDouble: {1:f2} lv.\nSuite: {2:f2} lv.", studio * (nights - 1), Double * nights, suite * nights);
            }else
            {
                Console.WriteLine("Studio: {0:f2} lv.\nDouble: {1:f2} lv.\nSuite: {2:f2} lv.", studio * nights, Double * nights, suite * nights);
            }
            
        }
    }
}
