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

            List<string> Input = Console.ReadLine().Split(' ').ToList();

            string first = Input[0];
            string second = Input[1];
            bool output = false;
            Dictionary<char, char> Map = new Dictionary<char, char>();

            string First = "";
            string Second = "";
            if (first.Length <= second.Length)
            {
                First = first;
                Second = second;
            }
            else
            {
                First = second;
                Second = first;
            }
            for (int i = 0; i < Math.Min(first.Length,second.Length); i++)
            {
                //&& !Map.ContainsKey(second[i]) && !Map.ContainsValue(first[i]) && !Map.ContainsValue(second[i])
                if (!Map.ContainsKey(First[i]))
                {
                    if (Map.ContainsValue(Second[i]))
                    {
                        output = false;
                        break;
                    }
                    else
                    {
                        Map.Add(First[i], Second[i]);
                        output = true;
                    }
                }
                else if (Map.ContainsKey(First[i]))
                {
                    if (Map[First[i]] == Second[i])
                    {
                       
                        output = true;
                    }
                    else
                    {
                        output = false;
                        break;
                    }
                    
                }
               
            }

            if (First.Length - Second.Length !=0)
            {
                for (int i = First.Length; i < Second.Length; i++)
                {
                    if (Map.ContainsValue(Second[i]))
                    {
                        output = true;
                    }
                    else
                    {
                        output = false;
                        break;
                    }
                    
                }
            }
            Console.WriteLine(output.ToString().ToLower());
        }
    }
}
