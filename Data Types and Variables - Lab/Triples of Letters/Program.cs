using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triples_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());

            
                char firstcharacter = (char)('a' + num -1);

            for (char i = 'a'; i <= firstcharacter ; i++)
            {
                for (char y = 'a'; y <= firstcharacter; y++)
                {
                    for (char z = 'a'; z <= firstcharacter ; z++)
                    {
                        Console.WriteLine("{0}{1}{2}",i , y, z);
                    }
                }
            }

            



        }
    }
}
