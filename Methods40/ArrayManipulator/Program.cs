using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> Input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            while (true)
            {
                List<string> commands = Console.ReadLine().Split(' ').ToList();
                if (commands[0] == "end")
                {
                    Console.WriteLine("[" + string.Join(", ", Input) + "]");
                    break;
                }

                if (commands[0] == "exchange")
                {
                    int index = Convert.ToInt32(commands[1].ToString());
                    if (index >= Input.Count() || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    else
                    {

                        List<int> firstPart = new List<int>();
                        List<int> secondPart = new List<int>();
                        for (int i = 0; i < Input.Count; i++)
                        {

                            if (i <= index)
                            {
                                firstPart.Add(Input[i]);
                            }
                            else
                            {
                                secondPart.Add(Input[i]);
                            }

                        }
                        Input = new List<int>();
                        Input.AddRange(secondPart);
                        Input.AddRange(firstPart);

                    }
                }

                if (commands[0] == "max")
                {
                    if (commands[1] == "even")
                    {

                        List<int> EvenList = Input.Where(a => a % 2 == 0).ToList();
                        if (EvenList.Count() == 0)
                        {
                            Console.WriteLine("No matches");
                            continue;
                        }
                        else
                        {
                            int maxEvennumber = EvenList.Max();
                            int index = -1;
                            for (int i = 0; i < Input.Count; i++)
                            {
                                if (Input[i] == maxEvennumber)
                                {
                                    index = i;
                                }
                            }
                            Console.WriteLine(index);
                            continue;
                        }

                    }
                    else if (commands[1] == "odd")
                    {
                        List<int> OddList = Input.Where(a => a % 2 != 0).ToList();
                        if (OddList.Count() == 0)
                        {
                            Console.WriteLine("No matches");
                            continue;
                        }
                        else
                        {
                            int maxOddNumber = OddList.Max();
                            int index = -1;
                            for (int i = 0; i < Input.Count; i++)
                            {
                                if (Input[i] == maxOddNumber)
                                {
                                    index = i;
                                }
                            }
                            Console.WriteLine(index);
                            continue;
                        }
                    }
                }

                if (commands[0] == "min")
                {
                    if (commands[1] == "even")
                    {

                        List<int> EvenList = Input.Where(a => a % 2 == 0).ToList();
                        if (EvenList.Count() == 0)
                        {
                            Console.WriteLine("No matches");
                            continue;
                        }
                        else
                        {
                            int minEvenNumber = EvenList.Min();
                            int index = -1;
                            for (int i = 0; i < Input.Count; i++)
                            {
                                if (Input[i] == minEvenNumber)
                                {
                                    index = i;
                                }
                            }
                            Console.WriteLine(index);
                            continue;
                        }

                    }
                    else if (commands[1] == "odd")
                    {
                        List<int> OddList = Input.Where(a => a % 2 != 0).ToList();
                        if (OddList.Count() == 0)
                        {
                            Console.WriteLine("No matches");
                            continue;
                        }
                        else
                        {
                            int minOddNumber = OddList.Min();
                            int index = -1;
                            for (int i = 0; i < Input.Count; i++)
                            {
                                if (Input[i] == minOddNumber)
                                {
                                    index = i;
                                }
                            }
                            Console.WriteLine(index);
                            continue;
                        }
                    }
                }
                ///////////////////////////////

                if (commands[0] == "first")
                {
                    int count = Convert.ToInt32(commands[1].ToString());
                    if (count > Input.Count() || count < 0)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }
                    if (commands[2] == "even")
                    {
                        List<int> EvenList = Input.Where(a => a % 2 == 0).ToList();
                        List<int> RequiredNumberOfEven = new List<int>();
                        for (int i = 0; i < EvenList.Count(); i++)
                        {
                          
                           
                            if (count > 0)
                            {
                                RequiredNumberOfEven.Add(EvenList[i]);
                            }
                            else
                            {
                                break;
                            }
                            count--;
                        }
                        Console.WriteLine("[" + string.Join(", ", RequiredNumberOfEven) + "]");
                        continue;
                    }
                    else if (commands[2] == "odd")
                    {

                        List<int> OddList = Input.Where(a => a % 2 != 0).ToList();
                        List<int> RequiredNumberofOdd = new List<int>();
                        for (int i = 0; i < OddList.Count(); i++)
                        {

                            
                            if (count > 0)
                            {
                                RequiredNumberofOdd.Add(OddList[i]);
                            }
                            else
                            {
                                break;
                            }

                            count--;
                        }
                        Console.WriteLine("[" + string.Join(", ", RequiredNumberofOdd) + "]");
                        continue;

                    }

                }


                if (commands[0] == "last")
                {
                    int count = Convert.ToInt32(commands[1].ToString());
                    if (count > Input.Count() || count < 0)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }
                    if (commands[2] == "even")
                    {
                        List<int> EvenList = Input.Where(a => a % 2 == 0).ToList();
                        EvenList.Reverse();
                        List<int> RequiredNumberOfEven = new List<int>();
                        for (int i = 0; i < EvenList.Count(); i++)
                        {

                          
                            if (count > 0)
                            {
                                RequiredNumberOfEven.Add(EvenList[i]);
                            }
                            else
                            {
                                break;
                            }

                            count--;
                        }
                        RequiredNumberOfEven.Reverse();
                        Console.WriteLine("[" + string.Join(", ", RequiredNumberOfEven) + "]");
                        continue;
                    }
                    else if (commands[2] == "odd")
                    {

                        List<int> OddList = Input.Where(a => a % 2 != 0).ToList();
                        OddList.Reverse();
                        List<int> RequiredNumberofOdd = new List<int>();
                        for (int i = 0; i < OddList.Count(); i++)
                        {

                           
                            if (count > 0)
                            {
                                RequiredNumberofOdd.Add(OddList[i]);
                            }
                            else
                            {
                                break;
                            }
                            count--;
                        }
                        RequiredNumberofOdd.Reverse();
                        Console.WriteLine("[" + string.Join(", ", RequiredNumberofOdd) + "]");
                        continue;

                    }

                }
            }


        }
    }
}

