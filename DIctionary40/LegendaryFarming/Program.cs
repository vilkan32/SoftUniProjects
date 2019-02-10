using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> JunkNumber = new Dictionary<string, int>();
            Dictionary<string, int> KeyMaterial = new Dictionary<string, int>();
            KeyMaterial.Add("shards", 0);
            KeyMaterial.Add("motes", 0);
            KeyMaterial.Add("fragments", 0);
            bool reachedLegendary = false;
            while (true)
            {
                if (reachedLegendary == true)
                {
                    break;
                }
                List<string> Input = Console.ReadLine().Split(' ').ToList();

                for (int i = 0; i < Input.Count - 1; i++)
                {
                    string material = Input[i + 1].ToLower();
                    int quantity = int.Parse(Input[i]);
                    if (material == "shards" || material == "motes"|| material == "fragments")
                    {
                        if (material == "shards")
                        {
                            if (!KeyMaterial.ContainsKey(material))
                            {
                                KeyMaterial.Add("shards", quantity);
                            }
                            else
                            {
                                KeyMaterial["shards"] += quantity;
                            }
                            if (KeyMaterial["shards"] >= 250)
                            {
                                KeyMaterial["shards"] -= 250;
                                reachedLegendary = true;
                                Console.WriteLine("Shadowmourne obtained!");
                                break;
                            }
                        }
                        else if (material == "motes")
                        {
                            if (!KeyMaterial.ContainsKey(material))
                            {
                                KeyMaterial.Add("motes", quantity);
                              
                            }
                            else
                            {
                                KeyMaterial["motes"] += quantity;
                            }
                            if (KeyMaterial["motes"] >= 250)
                            {
                                KeyMaterial["motes"] -= 250;
                                reachedLegendary = true;
                                Console.WriteLine("Dragonwrath obtained!");
                                break;
                            }
                        }
                        else if (material == "fragments")
                        {
                            if(!KeyMaterial.ContainsKey(material))
                            {
                                KeyMaterial.Add("fragments", quantity);
                            }
                            else
                            {
                                KeyMaterial["fragments"] += quantity;
                            }
                            if (KeyMaterial["fragments"] >= 250)
                            {
                                KeyMaterial["fragments"] -= 250;
                                reachedLegendary = true;
                                Console.WriteLine("Valanyr obtained!");
                                break;
                            }
                        }
                        i++;
                    }
                    else
                    {
                        if (JunkNumber.ContainsKey(material))
                        {
                            JunkNumber[material] += quantity;
                            i++;
                        }
                        else
                        {
                            JunkNumber.Add(material, quantity);
                            i++;
                        }
                    }
                }

            }

            foreach (var item in KeyMaterial.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine(item.Key+ ": " + item.Value);
            }
            foreach (var item in JunkNumber.OrderBy(x => x.Key))
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }
}
