using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {



            List<int> Input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int counter = 0;
            int previouscounter = 0;
            Input.Sort();
            List<int> Output = new List<int>();
            int previousnumber = int.MaxValue;
            List<int> OutputTheCounter = new List<int>();

            foreach (var item in Input)
            {
                if (item == previousnumber)
                {
                    continue;
                }
                for (int i = 0; i < Input.Count; i++)
                {
                    try
                    {
                        if (item == Input[i + previouscounter])
                        {
                            counter++;
                        }
                        else
                        {
                            previouscounter += counter;
                            OutputTheCounter.Add(counter);
                            counter = 0;
                            previousnumber = item;
                            Output.Add(item);

                            break;
                        }
                    }
                    catch (Exception)
                    {

                        Output.Add(item);

                        OutputTheCounter.Add(counter);
                        previousnumber = item;
                        break;
                    }

                }

                if (Input.Count == counter)
                {
                    Output.Add(item);
                    OutputTheCounter.Add(counter);
                }
            }

            for (int i = 0; i < Output.Count; i++)
            {
                Console.WriteLine(Output[i] + " -> " + OutputTheCounter[i]);
            }



        }
    }
}
