using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, List<string>> userIP = new SortedDictionary<string, List<string>>();

            while (true)
            {

                string input = Console.ReadLine();
                if (input == "end")
                    break;

                List<string> splitinput = input.Split(' ').ToList();
                List<string> userlist = splitinput[2].Split('=').ToList();
                List<string> IPlist = splitinput[0].Split('=').ToList();
                string user = userlist[1];
                List<string> IP = new List<string>();
                IP.Add(IPlist[1]);
                if (!userIP.ContainsKey(user))
                {
                    userIP.Add(user, new List<string>());
                }

                userIP[user].AddRange(IP);

            }
            Dictionary<string, int> trysomething = new Dictionary<string, int>();
            foreach (var item in userIP)
            {
                int counter = 0;

                for (int i = 0; i < item.Value.Count(); i++)
                {
                    
                    string output = item.Value[i];
                    if (!trysomething.ContainsKey(output))
                    {
                        trysomething.Add(output, 0);
                    }
                    trysomething[output]++;
                }
                
                if (trysomething.Count > 1)
                {
                    Console.WriteLine("{0}:", item.Key);
                    foreach (var IP in trysomething)
                    {
                        counter++;
                        if (counter == trysomething.Count)
                        {
                            Console.Write("{0} => {1}.",IP.Key,IP.Value);
                        }
                        else
                        {
                            Console.Write("{0} => {1}, ", IP.Key, IP.Value);
                        }
                        
                    }
                    Console.WriteLine();
                    counter = 0;
                }
                else
                {
                    Console.WriteLine("{0}:", item.Key);
                    foreach (var output in trysomething)
                    {
                        Console.Write("{0} => {1}.", output.Key, output.Value);
                    }
                    Console.WriteLine();
                }
                trysomething = new Dictionary<string, int>();

            }



        }
    }
}
