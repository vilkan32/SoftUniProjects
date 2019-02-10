using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {

            List<double> Input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            
            int counter = 0;
            int excounter = 0;
            int newi = 0;
            List<double> Output = new List<double>();
            double exitem = double.MaxValue;
            int broipreminavaniq = 0;
            foreach (var item in Input)
            {
                if (exitem == item)
                {
                    continue;
                }
                for (int i = 0; i < Input.Count; i++)
                {
                    try
                    {
                        if (item == Input[i + newi])
                        {
                            counter++;
                        }
                        else
                        {
                            if (excounter < counter)
                            {
                                excounter = counter;
                                if (broipreminavaniq >= 0)
                                {
                                    Output = new List<double>();
                                }
                                for (int c = 0; c < counter; c++)
                                {
                                   
                                    broipreminavaniq++;
                                    Output.Add((int)item);
                                }
                            }
                            
                            newi += counter;
                            exitem = item;
                            counter = 0;
                            break;

                        }
                    }
                    catch (Exception)
                    {

                        if (excounter < counter)
                        {
                            excounter = counter;
                            if (broipreminavaniq >= 0)
                            {
                                Output = new List<double>();
                            }
                           
                            for (int c = 0; c < counter; c++)
                            {
                                Output.Add((int)item);
                            }
                        }
                        
                        newi += counter;
                        exitem = item;
                        counter = 0;
                        break;
                    }

                    if (Input.Count == counter)
                    {
                        Output = Input;
                    }
                }
                counter = 0;
            }
            Console.WriteLine(string.Join(" ", Output));


        }
    }
}
