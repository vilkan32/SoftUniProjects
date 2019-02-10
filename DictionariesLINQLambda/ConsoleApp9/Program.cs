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
            Dictionary<string, long> Output = new Dictionary<string, long>();

            string Input = Console.ReadLine();
            string result = "";
            
            while (Input != "stop")
            {
              
                if (!Output.ContainsKey(Input))
                {
                    Output.Add(Input, 0);
                }
               
                result = Input;
                Input = Console.ReadLine();

                Output[result] += Convert.ToInt64(Input);
                Input = Console.ReadLine();
            }

            foreach (KeyValuePair<string,long> output in Output)
            {

                Console.WriteLine("{0} -> {1}", output.Key, output.Value);

            }

        }
    }
}
