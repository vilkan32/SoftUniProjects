using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {


            List<string> Input = Console.ReadLine().Split(':').ToList();
            List<string> Names = new List<string>();
            List<int> values = new List<int>();
            while (Input[0] != "JOKER")
            {
                List<string> Cards = Input[1].Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Distinct().ToList();
                Names.Add(Input[0]);
                for (int i = 0; i < Cards.Count(); i++)
                {
                    string line = Cards[i];
                    string power = line[0].ToString();
                    string type = line[1].ToString();

                    
                    if (Cards[i].Count() == 3)
                    {
                         type = line[2].ToString();
                    }
                    


                }


            }



        }
    }
}
