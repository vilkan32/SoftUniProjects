using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] Input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            List<int> Print = new List<int>();
            int counter = 0;
            while (true)
            {
                if (counter == 3)
                {
                    break;
                }
                string[] input = Console.ReadLine().Split(' ').ToArray();

                if (input[0] == "Replace")
                {
                    try
                    {
                        Convert.ToInt32(input[1]);
                    }
                    catch (System.FormatException)
                    {
                        counter++;
                        Console.WriteLine("The variable is not in the correct format!");
                        continue;
                    }
                    try
                    {
                        Input[Convert.ToInt32(input[1])] = Convert.ToInt32(input[2]);
                    }
                    catch (Exception)
                    {
                        counter++;
                        Console.WriteLine("The index does not exist!");
                    }
                }
                else if (input[0] == "Print")
                {
                    try
                    {
                        for (int i = Convert.ToInt32(input[1]); i <= Convert.ToInt32(input[2]); i++)
                        {
                            Print.Add(Input[i]);
                        }
                        Console.WriteLine(string.Join(", ", Print));
                        Print = new List<int>();
                    }
                    catch (Exception)
                    {
                        counter++;
                        Console.WriteLine("The index does not exist!");
                    }
                }
                else if (input[0] == "Show")
                {
                    try
                    {
                        Convert.ToInt32(input[1]);
                    }
                    catch (System.FormatException)
                    {
                        counter++;
                        Console.WriteLine("The variable is not in the correct format!");
                        continue;
                    }

                    try
                    {
                        Console.WriteLine(Input[Convert.ToInt32(input[1])]);
                    }
                    catch (System.IndexOutOfRangeException)
                    {
                        counter++;
                        Console.WriteLine("The index does not exist!");
                    }

                }

            }

            Console.WriteLine(string.Join(", ",Input));
        }
    }
}
