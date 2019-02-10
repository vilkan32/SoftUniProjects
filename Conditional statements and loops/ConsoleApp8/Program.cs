using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {

            char first = char.Parse(Console.ReadLine().ToLower());

            char second = char.Parse(Console.ReadLine().ToLower());

            char stop = char.Parse(Console.ReadLine().ToLower());

            for (char i = first; i <= second; i++)
            {
                for (char y = first; y <= second; y++)
                {
                    for (char z = first; z <= second; z++)
                    {
                        if (i == stop|| y == stop|| z == stop  )
                        {
                            continue;
                        }
                        else
                        {
                            Console.Write("{0}{1}{2} ",i,y,z);
                        }
                    }
                }
            }





        





        }
    }
}
