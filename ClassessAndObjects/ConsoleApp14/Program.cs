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
            List<Team> TeamList = new List<Team>();
            
            int a = int.Parse(Console.ReadLine());

            for (int i = 0; i < a; i++)
            {
                string[] input = Console.ReadLine().Split('-').ToArray();
                string creator = input[0];
                string teamname = input[1];
                int counter = 0;
                for (int x = 0; x < TeamList.Count; x++)
                {
                    if (TeamList[x].NameOftheTeam == teamname)
                    {
                        Console.WriteLine("Team {0} was already created!", TeamList[x].NameOftheTeam);
                        counter++;
                        break;
                    }
                    
                }
                if (counter != 0)
                {
                    continue;
                }
                for (int x = 0; x < TeamList.Count; x++)
                {
                    if (TeamList[x].Creator == creator)
                    {
                        Console.WriteLine("{0} cannot create another team!", TeamList[x].Creator);
                        counter++;
                        break;
                    }

                }
                if (counter != 0)
                {
                    continue;
                }
                Team CurrentTeam = new Team();
                CurrentTeam.Members = new List<string>();
                CurrentTeam.NameOftheTeam = teamname;
                CurrentTeam.Creator = creator;
                TeamList.Add(CurrentTeam);
                Console.WriteLine("Team {0} has been created by {1}!", teamname,creator);
            }

            while (true)
            {
                string[] input = Console.ReadLine().Split(new char[] {'-','>'}, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (input[0] == "end of assignment")
                {
                    break;
                }
                // da se napravqt dva for cikula

                int counterforequalofthename = 0;
                int counterforname = 0;

                for (int X = 0; X < TeamList.Count; X++)
                {
                    if (TeamList[X].NameOftheTeam == input[1])
                    {
                        counterforequalofthename++;
                        break;

                    }
                }
                if (counterforequalofthename == 0)
                {
                    Console.WriteLine("Team {0} does not exist!", input[1]);
                    continue;
                }
                for (int i = 0; i < TeamList.Count; i++)
                {
                   
                
                    for (int X = 0; X < TeamList[i].Members.Count(); X++)
                    {
                        if (TeamList[i].Members[X] == input[0])
                        {
                            Console.WriteLine("Member {0} cannot join team {1}!", input[0], input[1]);
                            counterforname++;
                            break;
                        }
                    }

                    
                    if (TeamList[i].Creator == input[0])
                    {
                        Console.WriteLine("Member {0} cannot join team {1}!", input[0], input[1]);
                        counterforname++;
                        break;
                    }

                }


                if (counterforname !=0)
                {
                    continue;
                }

                for (int i = 0; i < TeamList.Count(); i++)
                {
                    if (TeamList[i].NameOftheTeam == input[1])
                    {
                        TeamList[i].Members.Add(input[0]);
                        break;
                    }
                }



            }

            List<Team> TeamsToDisband = new List<Team>();
            foreach (var item in TeamList.OrderByDescending(x => x.Members.Count()).ThenBy(x => x.NameOftheTeam))
            {
                if (item.Members.Count == 0)
                {
                    TeamsToDisband.Add(item);
                    continue;
                }
                Console.WriteLine("{0}",item.NameOftheTeam);
                Console.WriteLine("- {0}", item.Creator);
                foreach (var items in item.Members.OrderBy(x => x)) 
                {
                    Console.WriteLine("-- {0}",items);
                }
            }
            Console.WriteLine("Teams to disband:");
            foreach (var item in TeamsToDisband.OrderBy(x => x.NameOftheTeam))
            {
                Console.WriteLine(item.NameOftheTeam);
            }


        }
    }
    class Team
    {
        public string NameOftheTeam { get; set; }
        public List<string> Members { get; set; }
        public string Creator { get; set; }

    }
}
