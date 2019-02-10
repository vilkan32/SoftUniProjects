using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> Input = Console.ReadLine().Split(':').ToList();

            List<string> CardTypes = Input[1].Split(new char[] { ',',' ', }, StringSplitOptions.RemoveEmptyEntries).Distinct().ToList();
            Dictionary<char, int> Power = new Dictionary<char, int>();
            Dictionary<char, int> Type = new Dictionary<char, int>();
            Type['S'] = 4;
            Type['H'] = 3;
            Type['D'] = 2;
            Type['C'] = 1;
            Dictionary<string, int> PeopleSum = new Dictionary<string, int>();
            List<int> OutputValues = new List<int>();
            while (Input[0] != "JOKER")
            {
                CardTypes = Input[1].Split(new char[] { ',', ' ', }, StringSplitOptions.RemoveEmptyEntries).Distinct().ToList();
                foreach (var card in CardTypes)
                {

                    
                    if (!Power.ContainsKey(card[0]))
                    {
                        
                        if (card[0] == 'J')
                        {
                            Power.Add(card[0], 11);
                        }
                        else if (card[0] == 'Q')
                        {
                            Power.Add(card[0], 12);
                        }
                        else if (card[0] == 'K')
                        {
                            Power.Add(card[0], 13);
                        }
                        else if (card[0] == 'A')
                        {
                            Power.Add(card[0], 14);
                        }
                        else
                        {
                            //  int cardvalue = int.Parse(card[0].ToString());
                            // Power.Add(card[0], cardvalue);
                            try
                            {
                                int cardvalue = int.Parse(card[0].ToString());
                                int cardvalue1 = int.Parse(card[1].ToString());
                                string outputvalue = cardvalue.ToString() + cardvalue1.ToString();
                                Power.Add(card[0], Convert.ToInt32(outputvalue));
                            }
                            catch (Exception)
                            {

                                int cardvalue = int.Parse(card[0].ToString());

                                Power.Add(card[0], Convert.ToInt32(cardvalue));
                            }
                        }
                        
                    }
                    else
                    {
                        if (card[0] == 'J')
                        {
                            Power[card[0]] = 11;
                        }
                        else if (card[0] == 'Q')
                        {
                            Power[card[0]] = 12;
                        }
                        else if (card[0] == 'K')
                        {
                            Power[card[0]] = 13;
                        }
                        else if (card[0] == 'A')
                        {
                            Power[card[0]] = 14;
                        }
                        else
                        {
                            try
                            {
                                int cardvalue = int.Parse(card[0].ToString());
                                int cardvalue1 = int.Parse(card[1].ToString());
                                string outputvalue = cardvalue.ToString() + cardvalue1.ToString();
                                Power[card[0]] += Convert.ToInt32(outputvalue);
                            }
                            catch (Exception)
                            {

                                int cardvalue = int.Parse(card[0].ToString());

                                Power[card[0]] += cardvalue;
                            }
                        }


                    }

                    if (!PeopleSum.ContainsKey(Input[0]))
                    {
                        PeopleSum.Add(Input[0], 0);
                    }
                    

                    if (Type.ContainsKey(card[1]))
                    {
                        OutputValues.Add(Type[card[1]] * Power[card[0]]);
                    }
                    else
                    {
                        int cardvalue = int.Parse(card[0].ToString());
                        int cardvalue1 = int.Parse(card[1].ToString());
                        string outputvalue = cardvalue.ToString() + cardvalue1.ToString();
                       OutputValues.Add(Convert.ToInt32(outputvalue) * Type[card[2]]);
                    }
                    
                }
                PeopleSum[Input[0]] += OutputValues.Sum();
                Power = new Dictionary<char, int>();
                OutputValues = new List<int>();
                Input = Console.ReadLine().Split(':').ToList();
               
            }
            foreach (KeyValuePair<string, int> result in PeopleSum)
            {
                Console.WriteLine("{0}: {1}", result.Key, result.Value);
            }



        }
    }
}
