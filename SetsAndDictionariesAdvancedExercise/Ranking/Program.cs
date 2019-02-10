using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> ContestPassword = new Dictionary<string, string>();
            while (true)
            {
                string[] contestPassword = Console.ReadLine().Split(':');
                if (contestPassword[0] == "end of contests")
                {
                    break;
                }
                if (!ContestPassword.ContainsKey(contestPassword[0]))
                {
                    ContestPassword.Add(contestPassword[0], contestPassword[1]);
                }
            }

            SortedDictionary<string, Dictionary<string, int>> StudentContestPoints = new SortedDictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(new char[] {'=', '>' }, StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "end of submissions")
                {
                    break;
                }
                if (ContestPassword.ContainsKey(input[0]) && ContestPassword[input[0]] == input[1])
                {
                    if (!StudentContestPoints.ContainsKey(input[2]))
                    {
                        StudentContestPoints.Add(input[2], new Dictionary<string, int>());

                        StudentContestPoints[input[2]].Add(input[0], int.Parse(input[3]));

                    }
                    else
                    {
                        if (StudentContestPoints[input[2]].ContainsKey(input[0]))
                        {
                            if (StudentContestPoints[input[2]][input[0]] < int.Parse(input[3]))
                            {
                                StudentContestPoints[input[2]][input[0]] = int.Parse(input[3]);
                            }

                        }
                        else
                        {
                            StudentContestPoints[input[2]].Add(input[0], int.Parse(input[3]));
                        }   
                    }
                }
            }
            string candidae = string.Empty;
            int points = 0;
            foreach (var item in StudentContestPoints)
            {
                int current = 0;
                foreach (var set in item.Value)
                {
                    current += set.Value;
                }
                if (current > points)
                {
                    points = current;
                    candidae = item.Key;
                }
                
            }

            Console.WriteLine("Best candidate is {0} with total {1} points.", candidae, points);
            Console.WriteLine("Ranking:");
            foreach (var item in StudentContestPoints)
            {
                Console.WriteLine(item.Key);
                foreach (var set in item.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine("#  {0} -> {1}", set.Key, set.Value);
                }
            }
        }
    }
   
}
