using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            int countSequences = int.Parse(Console.ReadLine());

            for (int i = 0; i < countSequences; i++)
            {

                string[] input = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                List<int> numbers = new List<int>();

                bool found = false;

                for (int j = 0; j < input.Length; j++)
                {

                    int num = int.Parse(input[(int)j]);
                    numbers.Add(num);
                    if (num >= 0)
                    {
                        if (found)
                        {
                            Console.Write(" ");
                        }
                        
                        Console.Write(num);

                        found = true;
                    }
                    else
                    {
                        try
                        {
                            num += int.Parse(input[(int)j + 1]);
                        }
                        catch (Exception)
                        {

                            
                        }

                        if (num >= 0)
                        {
                            if (found)
                            {
                                Console.Write(" ");
                            }

                            Console.Write(num);
                            j++;
                            found = true;
                        }
                        else
                        {
                            j++;

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
