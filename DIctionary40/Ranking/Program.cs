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
            List<ContestPasswords> ContestLocker = new List<ContestPasswords>();
            while (true)
            {
                List<string> Input = Console.ReadLine().Split(':').ToList();
                if (Input[0] == "end of contests")
                {
                    break;
                }
                ContestPasswords Local = new ContestPasswords();
                Local.Name = Input[0];
                Local.Password = Input[1];
                ContestLocker.Add(Local);
               
            }
            List<ContestPasswrdUsernamePoints> Results = new List<ContestPasswrdUsernamePoints>();
            while (true)
            {
                // “{contest}=>{password}=>{username}=>{points}” until you receive “end of submissions”. Here is what you need to do. 
                List<string> Input = Console.ReadLine().Split(new char[] {'=', '>' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                if (Input[0] == "end of submissions")
                {
                    break;
                }
                ContestPasswrdUsernamePoints local = new ContestPasswrdUsernamePoints();
                bool cango = true;
                for (int i = 0; i < ContestLocker.Count(); i++)
                {
                    if (Input[0] == ContestLocker[i].Name && Input[1] == ContestLocker[i].Password)
                    {
                        for (int x = 0; x < Results.Count(); x++)
                        {
                            if (Results[x].Name == Input[0] && Results[x].Password == Input[1] && Results[x].Username == Input[2])
                            {
                                if (Results[x].Points < int.Parse(Input[3]))
                                {
                                    Results[x].Points = int.Parse(Input[3]);
                                    
                                }
                                cango = false;
                            }
                        }
                    }

                    if (cango == true)
                    {
                        if (Input[0] == ContestLocker[i].Name && Input[1] == ContestLocker[i].Password)
                        {
                            local.Name = Input[0];
                            local.Password = Input[1];
                            local.Username = Input[2];
                            local.Points = int.Parse(Input[3]);
                            Results.Add(local);
                        }
                    }
                }

            }

            Dictionary<string, int> Points = new Dictionary<string, int>();
            foreach (var item in Results)
            {
                if (Points.ContainsKey(item.Username))
                {
                    Points[item.Username] += item.Points;
                }
                else
                {
                    Points.Add(item.Username, item.Points);
                }
            }

            foreach (var item in Points.OrderByDescending(x => x.Value))
            {
                Console.WriteLine("Best candidate is {0} with total {1} points.", item.Key, item.Value);
                break;
            }

                Console.WriteLine("Ranking:");

            foreach (var item in Points.Keys.OrderBy(x => x))
            {
                Console.WriteLine(item);
                foreach (var set in Results.Where(x => x.Username == item).OrderByDescending(x => x.Points))
                {
                    Console.WriteLine("#  {0} -> {1}", set.Name, set.Points);
                }
            }
               
            
        }
    }
    class ContestPasswords
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public bool valid = true;
    }
    class ContestPasswrdUsernamePoints
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public int Points { get; set; }
        

    }
}
