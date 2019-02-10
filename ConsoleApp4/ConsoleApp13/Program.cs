using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        
        {
            var n = int.Parse(Console.ReadLine());
            int sum = 1;
            int output = 1;

            for (int i = 1; i <= n; i++)
            {

                
                Console.WriteLine("{0}", sum);
                sum+=2;


                if (i<n)
                {
                    output += sum;
                   
                }
                

                
              
                 
            }
            Console.WriteLine("Sum: {0}",output);
        }
    }
}
