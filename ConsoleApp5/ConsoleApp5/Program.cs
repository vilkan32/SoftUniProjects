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

            string ntype = Console.ReadLine();

            int count = int.Parse(Console.ReadLine());

            sbyte   sbyteoutpu = sbyte.MinValue;

            long longoutput = long.MinValue;

            int intoutput = int.MinValue;
            double additionalvalue = 0d;

            if (ntype == "sbyte")
            {
                for (int i = 1; i <=count; i++)
                {
                    
                    try
                    {

                        sbyte number = sbyte.Parse(Console.ReadLine());
                        if (number > sbyteoutpu)
                        {
                            sbyteoutpu = number;
                        }
                        

                    }
                    catch (Exception)
                    {

                        
                    }

                }

                if (sbyteoutpu>0)
                {
                    additionalvalue = (double)(Math.Abs(sbyteoutpu) / 127d);
                }
                else
                {
                    additionalvalue = (double)(Math.Abs(sbyteoutpu) / 128d);
                }

                additionalvalue = Math.Ceiling(additionalvalue);
                if (additionalvalue> 1)
                {
                    Console.WriteLine("Prisoner with id {0} is sentenced to {1} years", sbyteoutpu,additionalvalue);
                }
                else
                {
                    Console.WriteLine("Prisoner with id {0} is sentenced to {1} year",sbyteoutpu,additionalvalue);
                }



            }
            else if (ntype == "int")
            {
                for (int i = 1; i <= count; i++)
                {

                    try
                    {

                        int number = int.Parse(Console.ReadLine());
                        if (number > intoutput)
                        {
                            intoutput = number;
                        }


                    }
                    catch (Exception)
                    {


                    }
                }



                if (intoutput >0)
                {
                    additionalvalue = (double)(Math.Abs(intoutput) / 127d);
                }
                else
                {
                    additionalvalue = (double)(Math.Abs(intoutput) / 128d);
                }

                additionalvalue = Math.Ceiling(additionalvalue);
                if (additionalvalue > 1)
                {
                    Console.WriteLine("Prisoner with id {0} is sentenced to {1} years", intoutput, additionalvalue);
                }
                else
                {
                    Console.WriteLine("Prisoner with id {0} is sentenced to {1} year", intoutput, additionalvalue);
                }



            }
            else if (ntype == "long")
            {
                for (int i = 1; i <= count; i++)
                {

                    try
                    {

                        long number = long.Parse(Console.ReadLine());
                        if (number > longoutput)
                        {
                            longoutput = number;
                        }


                    }
                    catch (Exception)
                    {


                    }
                }

                if (longoutput> 0)
                {
                     additionalvalue = (double)(Math.Abs(longoutput) / 127d);
                }
                else
                {
                     additionalvalue = (double)(Math.Abs(longoutput) / 128d);
                }

                additionalvalue = Math.Ceiling(additionalvalue);
                if (additionalvalue > 1)
                {
                    Console.WriteLine("Prisoner with id {0} is sentenced to {1} years", longoutput, additionalvalue);
                }
                else
                {
                    Console.WriteLine("Prisoner with id {0} is sentenced to {1} year", longoutput, additionalvalue);
                }


            }




        }
    }
}
