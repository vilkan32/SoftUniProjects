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
            
            SortedDictionary<string, int> MaterialQuantity = new SortedDictionary<string, int>();
            SortedDictionary<string, int> UselessMaterialQuantity = new SortedDictionary<string, int>();
            MaterialQuantity.Add("fragments", 0);
            MaterialQuantity.Add("motes", 0);
            MaterialQuantity.Add("shards", 0);
            int counter = 0;


            while (true)
            {

                if (counter == 1)
                {
                    break;
                }
                string input = Console.ReadLine().ToLower();
               
                List<string> ParsedInput = input.Split(' ').ToList();
                List<string> Material = new List<string>();
                List<int> Quantity = new List<int>();

                for (int i = 0; i < ParsedInput.Count(); i++)
                {
                    
                    if (i % 2 != 0)
                    {

                        Material.Add(ParsedInput[i]);
                    }
                    else
                    {
                        Quantity.Add(Convert.ToInt32(ParsedInput[i]));
                    }
                    
                }

                for (int i = 0; i < Material.Count(); i++)
                {
                    if (!MaterialQuantity.ContainsKey(Material[i]))
                    {
                        if (!UselessMaterialQuantity.ContainsKey(Material[i]))
                        {
                            UselessMaterialQuantity.Add(Material[i], 0);
                        }
                        
                        UselessMaterialQuantity[Material[i]] += Quantity[i];
                        
                    }
                    else
                    {
                        MaterialQuantity[Material[i]] += Quantity[i];
                        if (MaterialQuantity[Material[i]] >= 250 && Material[i] == "shards")
                        {
                            //Shadowmourn
                            Console.WriteLine("Shadowmourne obtained!");
                            MaterialQuantity[Material[i]] -= 250;
                            counter++;
                            break;

                        }
                        else if (MaterialQuantity[Material[i]] >= 250 && Material[i] == "fragments")
                        {
                            //Valanyr
                            Console.WriteLine("Valanyr obtained!");
                            MaterialQuantity[Material[i]] -= 250;
                            counter++;
                            break;
                        }
                        else if (MaterialQuantity[Material[i]] >= 250 && Material[i] == "motes")
                        {
                            //Dragonwrath 
                            Console.WriteLine("Dragonwrath obtained!");
                            MaterialQuantity[Material[i]] -= 250;
                            counter++;
                            break;
                        }
                    }


                }

            }


            Dictionary<string, int> SoterMaterialQuantity = new Dictionary<string, int>();
            List<int> ValueOfTheElements = new List<int>();
            foreach (KeyValuePair<string,int> item in MaterialQuantity)
            {
                ValueOfTheElements.Add(item.Value);
            }
            ValueOfTheElements.Sort();
            ValueOfTheElements.Reverse();
            
                for (int i = 0; i < 3; i++)
                {
                  foreach (KeyValuePair<string, int> newitem in MaterialQuantity)
                  {
                    if (newitem.Value == ValueOfTheElements[i])
                    {
                        try
                        {
                            SoterMaterialQuantity.Add(newitem.Key, newitem.Value);
                        }
                        catch (Exception)
                        {

                            continue;
                        }
                    }

                  }
                }

            foreach (var item in SoterMaterialQuantity)
            {
                Console.WriteLine("{0}: {1}",item.Key,item.Value);
            }


            foreach (var item in UselessMaterialQuantity)
            {
                Console.WriteLine("{0}: {1}", item.Key, item.Value);
            }
        }
    }
}
