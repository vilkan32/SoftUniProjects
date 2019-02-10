using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
           

            
            Dictionary<string, List<string>> PersonSum = new Dictionary<string, List<string>>();
            
           
            while (true)
            {

              string  Input = Console.ReadLine();
                if (Input == "JOKER")
                {
                    break;
                }
                string[] tokens = Input.Split(':');
                string Player = tokens[0];
                string[] Cards = tokens[1].Trim().Split(new char[] { ',', ' '},StringSplitOptions.RemoveEmptyEntries);

                if (!PersonSum.ContainsKey(Player))
                {
                    PersonSum.Add(Player, new List<string>());
                }

                PersonSum[Player].AddRange(Cards);
            }
            Dictionary<string, int> powers = new Dictionary<string, int>();

            for (int i = 2; i <= 9; i++)
            {
                powers.Add(i.ToString(), i);
            }
            powers.Add("1", 10);
            powers.Add("S", 4);
            powers.Add("H", 3);
            powers.Add("D",2);
            powers.Add("C", 1);

            powers.Add("J", 11);
            powers.Add("Q", 12);
            powers.Add("K", 13);
            powers.Add("A", 14);
            foreach (var item in PersonSum)
            {
                List<string> distinctCards = item.Value.Distinct().ToList();
                int sum = 0;
                foreach (string card in distinctCards)
                {
                    string cardpower = card[0].ToString();
                    string cardtype = card[card.Length - 1].ToString();
                    int cardpowerint = powers[cardpower];
                    int cardtypeint = powers[cardtype];
                    sum += cardpowerint * cardtypeint;

                }
                Console.WriteLine("{0}: {1}", item.Key,sum);
                sum = 0;
            }

            
        }
    }
}
