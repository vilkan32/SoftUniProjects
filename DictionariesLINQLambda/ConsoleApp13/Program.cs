using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> Input = Console.ReadLine().Split(new char[] { ':' },StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> CardSet = Input[1].Split(new char[] { ' ', ',', ':' }, StringSplitOptions.RemoveEmptyEntries).Distinct().ToList();
            Dictionary<string, List<string>> PeopleCards = new Dictionary<string, List<string>>();
            List<string> say = new List<string>();
            int sum = 0;
           Dictionary<string,int> powers = new Dictionary<string, int>();
           
            powers["2"] = 2;
            powers["3"] = 3;
            powers["4"] = 4;
            powers["5"] = 5;
            powers["6"] = 6;
            powers["7"] = 7;
            powers["8"] = 8;
            powers["9"] = 9;
            powers["1"] = 10;
            powers["J"] = 11;
            powers["Q"] = 12;
            powers["K"] = 13;
            powers["A"] = 14;
            Dictionary<string,int> types = new Dictionary<string, int> ();
            types["C"] = 1;
            types["D"] = 2;
            types["H"] = 3;
            types["S"] = 4;


            while (Input[0] != "JOKER")
            {

                CardSet = Input[1].Split(new char[] { ' ', ','}, StringSplitOptions.RemoveEmptyEntries).Distinct().ToList();
                if (!PeopleCards.ContainsKey(Input[0]))
                {
                    PeopleCards.Add(Input[0], CardSet);
                    
                }
                else
                {
                    PeopleCards[Input[0]].AddRange(CardSet);                    
                }
             Input =  Console.ReadLine().Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            }
           
            foreach (var key in PeopleCards.Keys)
            {
                say = PeopleCards[key].Distinct().ToList();
                int P = 0;
                int T = 0;
                for (int i = 0; i < say.Count; i++)
                {
                    string trysometing = say[i];
                    string power = trysometing[0].ToString();
                    string type = "";
                    if (trysometing.Length == 3)
                    {
                        type = trysometing[2].ToString();
                    }
                    else
                    {
                        type = trysometing[1].ToString();
                    }

                    if (powers.ContainsKey(power))
                    {
                        P = powers[power];
                    }

                    if (types.ContainsKey(type))
                    {
                        T = types[type];
                    }
                    sum += T * P;
                   

                }
                Console.WriteLine("{0}: {1}",key, sum);
                sum = 0;

            }



        }
    }
}
