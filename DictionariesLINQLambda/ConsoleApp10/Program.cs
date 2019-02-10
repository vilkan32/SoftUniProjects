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
            Dictionary<string, string> PeopleEmails = new Dictionary<string, string>();

            string Input = Console.ReadLine();
            string Keyname = "";
            
            while (Input != "stop")
            {

                if (!PeopleEmails.ContainsKey(Input))
                {
                    PeopleEmails.Add(Input, "");
                }
                Keyname = Input;
                Input = Console.ReadLine();
                Input.Reverse();
               
                if (Input.EndsWith("us") || Input.EndsWith("uk"))
                {
                    PeopleEmails.Remove(Keyname);
                }
                else
                {
                    Input.Reverse();
                    PeopleEmails[Keyname] = Input;
                }
                
                Input = Console.ReadLine();
               
            }
            foreach (KeyValuePair<string,string> item in PeopleEmails)
            {
                Console.WriteLine("{0} -> {1}", item.Key,item.Value);
            }
        }
    }
}
