using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            long countSequences = long.Parse(Console.ReadLine());
            long a = 0;
            for (long i = 0; i < countSequences; i++)
            {
                string[] input = Console.ReadLine().Trim().Split(' ');
                var numbers = new List<long>();

               
                
                for (long j = 0; j < input.Length; j++)
                {
                    if (!input[j].Equals(string.Empty))
                    {
                        long num = long.Parse(input[j]);
                        if (num < 0)
                        {
                            for (long c = j +1;  c <= input.Length;  c++)
                            {

                                if (!input[c].Equals(string.Empty))
                                {
                                    num = num + long.Parse(input[c]);
                                    j = c;
                                    if (num >= 0)
                                    {
                                        break;
                                        
                                    }
                                    else
                                    {
                                        a++;
                                        break;
                                    }
                                    
                                }
                                else
                                {
                                    continue;
                                }
                            }
                            
                           
                        }
                        if (a>0)
                        {
                            a = 0;
                        }
                        else
                        {
                            numbers.Add(num);
                        }
                        
                    }
                }
                
                bool found = false;

                for (long j = 0; j < numbers.Count; j++)
                {
                    long currentNum = numbers[j];

                    if (currentNum >= 0)
                    {
                        if (found)
                        {
                            Console.Write(" ");
                        }

                        Console.Write(currentNum);

                        found = true;
                    }
                    else
                    {
                        currentNum += numbers[j + 1];

                        if (currentNum >= 0)
                        {
                            if (found)
                            {
                                Console.Write(" ");
                            }

                            Console.Write(currentNum);

                            found = true;
                        }
                    }
                    
                }

                if (!found)
                {
                    Console.Write("(empty)");
                }
                Console.WriteLine();
            }
        }
    }
}
