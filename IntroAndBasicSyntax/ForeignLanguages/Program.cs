using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeignLanguages
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, List<string>> Languages = new Dictionary<string, List<string>>();
            Languages.Add("English", new List<string>());
            Languages["English"].Add("USA");
            Languages["English"].Add("England");
            Languages.Add("Spanish", new List<string>());
            Languages["Spanish"].Add("Argentina");
            Languages["Spanish"].Add("Mexico");
            Languages["Spanish"].Add("Spain");

            string Input = Console.ReadLine();
            int counter = 0;
            foreach (var item in Languages)
            {
                foreach (var something in item.Value)
                {
                    if (something == Input)
                    {
                        Console.WriteLine(item.Key);
                        counter++;
                    }
                }

            }

            if (counter ==0)
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
