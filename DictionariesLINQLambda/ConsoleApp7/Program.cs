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
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();
            while (Input[0] != "END")
            {
                if (Input[0] == "ListAll")
                {
                    foreach (KeyValuePair<string, string> contacts in phonebook)
                    {
                        Console.WriteLine("{0} -> {1}", contacts.Key, contacts.Value);
                    }
                }
                else if (!phonebook.ContainsKey(Input[1]) && Input[0] == "A")
                {
                    phonebook.Add(Input[1], Input[2]);
                }
                else if(phonebook.ContainsKey(Input[1]) && Input[0] == "A")
                {
                    phonebook[Input[1]] = Input[2];
                }
                else if (Input[0] == "S" && !phonebook.ContainsKey(Input[1]))
                {
                    Console.WriteLine("Contact {0} does not exist.", Input[1]);
                }
                else if (Input[0] == "S" && phonebook.ContainsKey(Input[1]))
                {
                    Console.WriteLine("{0} -> {1}",Input[1], phonebook[Input[1]]);
                }
                
                Input = Console.ReadLine().Split(' ').ToList();

            }



        }
    }
}
