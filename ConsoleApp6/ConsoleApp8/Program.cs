using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                int tire = (n - 1) / 2;
                int middletire = 2;
                int tire1 = 1;

                for (int i = 1; i <= n / 2; i++)
                {
                    Console.Write(new string('-', tire));
                    Console.Write("*");
                    if (i > 1)
                    {
                        Console.Write(new string('-', middletire));
                        middletire += 2;
                    }
                    Console.Write('*');
                    Console.Write(new string('-', tire));
                    tire--;

                    Console.WriteLine();
                }
                for (int i = 1; i <= n / 2 - 1; i++)
                {

                    middletire = n;
                    Console.Write(new string('-', tire1));
                    Console.Write("*");
                    Console.Write(new string('-', middletire - tire1 * 2 - 2));
                    Console.Write('*');
                    Console.Write(new string('-', tire1));
                    tire1 += 1;
                    Console.WriteLine();


                }
            }
            else
            {
                var tire2 = n / 2;
                var middletire = 1;

                for (int row = 1; row <= n / 2 + 1; row++)
                {

                    Console.Write(new string('-', tire2));
                    if (row == 1)
                    {

                        Console.Write("*");
                        Console.Write(new string('-', tire2));
                        tire2 -= 1;
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Write('*');


                        Console.Write(new string('-', middletire));
                        Console.Write('*');
                        Console.Write(new string('-', tire2));
                        tire2 -= 1;
                        middletire += 2;
                        Console.WriteLine();

                    }
                }
                var tire100 = 1;
                var middletire100 = n - (2 * tire100 + 2);

                for (int i = 1; i <= n / 2 - 1; i++)
                {
                    Console.Write(new string('-', tire100));
                    Console.Write('*');
                    Console.Write(new string('-', middletire100));
                    Console.Write('*');
                    Console.Write(new string('-', tire100));
                    tire100 += 1;
                    middletire100 -= 2;
                    Console.WriteLine();


                }
                if (n != 1)
                {
                    for (int i = 1; i <= 1; i++)
                    {
                        Console.Write(new string('-', tire100)); Console.Write('*'); Console.Write(new string('-', tire100));
                    }
                }
            }
        }
    }
}
