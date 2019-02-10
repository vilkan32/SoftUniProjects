using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Input = Console.ReadLine().Split(' ').ToList();

            string first = Input[0];
            string second = Input[1];

            Dictionary<char, string> Map = new Dictionary<char, string>();

            if (first.Count() <= second.Count())
            {
                for (int i = 0; i < first.Count(); i++)
                {
                    if (!Map.ContainsKey(first[i]))
                    {
                        Map.Add(first[i], second[i].ToString());
                    }
                    else
                    {
                        Map[first[i]] += second[i].ToString();
                    }

                }
            }
            else
            {
                for (int i = 0; i < second.Count(); i++)
                {
                    if (!Map.ContainsKey(second[i]))
                    {
                        Map.Add(second[i], first[i].ToString());
                    }
                    else
                    {
                        Map[second[i]] += first[i].ToString();
                    }

                }
            }

            int counter = 0;
            foreach (var item in Map)
            {
                foreach (var items in item.Value)
                {
                    for (int i = 0; i < item.Value.Count(); i++)
                    {
                        if (items.ToString() != item.Value[i].ToString())
                        {
                            counter++;
                            break;
                        }
                      
                    }
                    if (counter != 0)
                    {
                        
                        break;
                    }
                }
                if (counter != 0)
                {
                    Console.WriteLine("false");
                    break;
                }
            }
            int counter1 = 0;
            if (counter == 0 && first.Count() > second.Count())
            {
                for (int i = second.Count() - 1; i < first.Count(); i++)
                {
                    string test = first[i].ToString();
                    foreach (var item in Map)
                    {
                        foreach (var items in item.Value)
                        {
                            if (test == items.ToString())
                            {
                                counter1++;
                                break;
                            }
                        }
                    }
                    
                }
                if (counter1 >= first.Count() - second.Count())
                {

                    Console.WriteLine("true");

                }
                else
                {
                    Console.WriteLine("false");

                }

            }
            else if(counter == 0 && first.Count() < second.Count())
            {
                for (int i = first.Count() ; i < second.Count(); i++)
                {
                    string test = second[i].ToString();
                    foreach (var item in Map)
                    {
                        foreach (var items in item.Value)
                        {
                            if (test == items.ToString())
                            {
                                counter1++;
                                
                            }
                        }
                    }
                    
                }
                if (counter1 >= second.Count() - first.Count())
                {

                    Console.WriteLine("true");
                    
                }
                else
                {
                    Console.WriteLine("false");
                    
                }
            }
            else if(counter == 0 && counter1 == 0)
            {
                Console.WriteLine("true");
            }
            

        }
    }
}
