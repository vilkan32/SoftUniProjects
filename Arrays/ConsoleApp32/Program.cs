using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    class Program
    {
        static void Main(string[] args)
        {


            List<int> Input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();



            List<int> specialnumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            
            int number = specialnumbers[0];
            int power = specialnumbers[1];
            int theindex = int.MaxValue;
            int output = 0;
            for (int i = 0; i < Input.Count; i++)
            {

                if (Input[i] == number)
                {
                    theindex = Input.IndexOf(number);
                    for (int c = 0; c < power * 2 + 1; c++)
                    {
                        try
                        {
                            if (theindex - power < 0 && c <= power + 1)
                            {
                                Input.RemoveAt(0);
                            }
                            else
                            {
                                Input.RemoveAt(theindex - power);
                            }
                           
                        }
                        catch (Exception)
                        {

                            break ;
                        }
                    }


                }
                else
                {
                    continue;
                }
                i = 0;

            }

            foreach (var item in Input)
            {
                output += item;
            }

            Console.WriteLine(output);


        }        
    }
}
