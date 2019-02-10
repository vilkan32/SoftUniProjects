using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {



            Dictionary<string, Dictionary<string, int>> StageSingers = new Dictionary<string, Dictionary<string, int>>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                    break;
              
                List<string> SingerName = input.Split('@').ToList();
                string singername= SingerName[0];
                int ticketsnumber = 0;
                int ticketsprice = 0;
                string stagename = "";
                if (!singername.EndsWith(" "))
                {
                    continue;
                }
                singername = SingerName[0].TrimEnd();
                int counter = 0;
                List<string> Stage = SingerName[1].Split(' ').ToList();
                for (int i = 0; i < Stage.Count - 1; i++)
                {
                    try
                    {
                        ticketsnumber = Convert.ToInt32(Stage[i]);
                        ticketsprice = Convert.ToInt32(Stage[i + 1]);
                        counter++;
                    }
                    catch (Exception)
                    {

                        continue;
                    }
                }
                if (counter == 0)
                {
                    continue;
                }
               
                Stage.Remove(ticketsprice.ToString()); Stage.Remove(ticketsnumber.ToString());
                stagename = string.Join(" ", Stage);

                if (!StageSingers.ContainsKey(stagename))
                {
                    StageSingers.Add(stagename, new Dictionary<string, int>());
                }
                if (!StageSingers[stagename].ContainsKey(singername))
                {
                    StageSingers[stagename].Add(singername, 0);
                    
                }
                StageSingers[stagename][singername] += ticketsnumber * ticketsprice;
            }

            List<int> orderedvalues = new List<int>();
            foreach (var items in StageSingers)
            {

                foreach (var item in items.Value)
                {
                    orderedvalues.Add(item.Value);
                }

            }
            orderedvalues.Sort(); orderedvalues.Reverse();
            Dictionary<string, Dictionary<string, int>> OrderedStageSingers = new Dictionary<string, Dictionary<string, int>>();
            foreach (var items in StageSingers)
            {

                
                    
                    for (int i = 0; i < orderedvalues.Count(); i++)
                    {
                    foreach (var item in items.Value)
                    {
                        if (item.Value == orderedvalues[i])
                        {

                            if (!OrderedStageSingers.ContainsKey(items.Key))
                            {
                                OrderedStageSingers.Add(items.Key, new Dictionary<string, int>());
                            }

                            if (!OrderedStageSingers[items.Key].ContainsKey(item.Key))
                            {
                                OrderedStageSingers[items.Key].Add(item.Key, item.Value);
                                break;
                            }


                        }
                    }
                    }
                

            }


            foreach (var item in OrderedStageSingers)
            {
                Console.WriteLine("{0}",item.Key);
                foreach (var items in item.Value)
                {
                    Console.WriteLine("#  {0} -> {1}",items.Key,items.Value);
                }
            }



        }
    }
}
