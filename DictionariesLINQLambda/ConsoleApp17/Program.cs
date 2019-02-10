using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            SortedDictionary<string, SortedDictionary<string, int>> UsersDictionaryFill = new SortedDictionary<string, SortedDictionary<string, int>>();


            for (int i = 1; i <= n; i++)
            {
                string input = Console.ReadLine();
                List<string> InputAsList = input.Split(' ').ToList();
                string username = InputAsList[1];
                string IP = InputAsList[0];
                int duration = Convert.ToInt32(InputAsList[2]);

                if (!UsersDictionaryFill.ContainsKey(username))
                {
                    UsersDictionaryFill.Add(username, new SortedDictionary<string, int>());
                }
                try
                {
                    UsersDictionaryFill[username].Add(IP, duration);
                }
                catch (Exception)
                {

                    UsersDictionaryFill[username][IP] += duration;
                    continue;
                }


            }
            SortedDictionary<string, int> KeyOutput = new SortedDictionary<string, int>();

            foreach (var item in UsersDictionaryFill)
            {
                foreach (var newitem in item.Value)
                {
                    if (!KeyOutput.ContainsKey(item.Key))
                    {
                        KeyOutput.Add(item.Key, 0);
                    }
                    
                  
                        KeyOutput[item.Key] += newitem.Value;
                    
                }

            }


            foreach (var item in UsersDictionaryFill)
            {
                string finalstring = "";
                Console.Write("{0}: {1} [",item.Key, KeyOutput[item.Key]);
                foreach (var newitem in item.Value)
                {
                    finalstring += newitem.Key + ", ";

                }
                finalstring = finalstring.TrimEnd();
                finalstring = finalstring.TrimEnd(new char[] { ',' });
                Console.Write(finalstring);
                Console.WriteLine("]");

            }

        }
    }
}
