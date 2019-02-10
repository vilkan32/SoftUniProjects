using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNA_Sequences
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            int numofcounts = 0;
            for (char one = 'A'; one <= 'T'; one++)
            {
                for (char two = 'A';  two <= 'T';  two++)
                {
                    for (char three = 'A'; three <= 'T'; three++)
                    {
                        if ((one == 'A' || one == 'C' || one == 'G' || one == 'T') &&
                             (two == 'A' || two == 'C' || two == 'G' || two == 'T') && (three == 'A' || three == 'C' || three == 'G' || three == 'T'))
                        {


                            int a = 0;
                            int c = 0;
                            int g = 0;
                            int t = 0;

                            if (one == 'A')
                            {
                                a += 1;
                            }
                            if (two == 'A')
                            {
                                a += 1;
                            }
                            if (three == 'A')
                            {
                                a += 1;
                            }
                            if (one == 'C')
                            {
                                c += 2;
                            }
                            if (two == 'C')
                            {
                                c += 2;
                            }
                            if (three == 'C')
                            {
                                c += 2;
                            }
                            if (one == 'G')
                            {
                                g += 3;
                            }
                            if (two == 'G')
                            {
                                g += 3;
                            }
                            if (three == 'G')
                            {
                                g += 3;
                            }
                            if (one == 'T')
                            {
                                t += 4;
                            }
                            if (two == 'T')
                            {
                                t += 4;
                            }
                            if (three == 'T')
                            {
                                t += 4;
                            }
                            int sum = a + c + g + t;
                            if (sum >= number)
                            {
                                Console.Write("O{0}{1}{2}O ", one, two, three);
                                numofcounts++;
                                if (numofcounts % 4 == 0)
                                {
                                    Console.WriteLine();
                                }
                            }
                            else
                            {
                                Console.Write("X{0}{1}{2}X ", one, two, three);
                                numofcounts++;
                                if (numofcounts % 4 == 0)
                                {

                                    Console.WriteLine();
                                }
                            }





                        }
                    }
                }
            }
        }
    }
}
