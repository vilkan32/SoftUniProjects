using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> Input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            while (true)
            {

                List<string> Commands = Console.ReadLine().Split(' ').ToList();
                if (Commands[0] == "End")
                {
                    break;
                }
                if (Commands[0] == "Add")
                {
                    Input.Add(Convert.ToInt32(Commands[1]));
                }
                else if (Commands[0] == "Insert")
                {

                    try
                    {
                        Input.Insert(Convert.ToInt32(Commands[2]), Convert.ToInt32(Commands[1]));
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("Invalid index");
                    }
                }
                else if (Commands[0] == "Remove")
                {

                    try
                    {
                        Input.RemoveAt(Convert.ToInt32(Commands[1]));
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("Invalid index");
                    }
                }
                else if (Commands[0] == "Shift")
                {
                

                        if (Commands[1] == "left")
                        {
                            int times = Convert.ToInt32(Commands[2]);

                            while (true)
                            {
                                if (times == 0)
                                {
                                break;
                                }
                                int n = Input[0];
                                Input.RemoveAt(0);
                                Input.Add(n);
                                times--;
                            }

                           
                        }
                        else if (Commands[1] == "right")
                        {
                        int times = Convert.ToInt32(Commands[2]);

                        while (true)
                        {
                            if (times == 0)
                            {
                                break;
                            }
                            int n = Input[Input.Count() - 1];
                            Input.RemoveAt(Input.Count() - 1);
                            Input.Insert(0,n);
                            times--;
                        }
                        }
                    }
                
               
                    

            }
            Console.WriteLine(string.Join(" ", Input));
        }
    }
}
