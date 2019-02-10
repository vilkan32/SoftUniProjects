using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Vlog> VlogerFollowersFollowing = new Dictionary<string, Vlog>();

            

            while (true)
            {
                string[] command = Console.ReadLine().Split(' ');

                if (command[0] == "Statistics")
                {
                    break;
                }

                if (command[1] == "joined" && command[2] == "The" && command[3] == "V-Logger")
                {
                    if (!VlogerFollowersFollowing.ContainsKey(command[0]))
                    {
                        VlogerFollowersFollowing.Add(command[0], new Vlog());
                       
                    }
                }

                if (command[1] == "followed" && command[0] != command[2] && VlogerFollowersFollowing.ContainsKey(command[0]) && VlogerFollowersFollowing.ContainsKey(command[2]))
                {
                    VlogerFollowersFollowing[command[0]].Following.Add(command[2]);
                    VlogerFollowersFollowing[command[2]].Followers.Add(command[0]);

                }

               
            }

            Console.WriteLine("The V-Logger has a total of {0} vloggers in its logs.", VlogerFollowersFollowing.Count());
            int go = 1;
            foreach (var item in VlogerFollowersFollowing.OrderByDescending(x => x.Value.Followers.Count).ThenBy(x => x.Value.Following.Count))
            {
                Console.WriteLine("{3}. {0} : {1} followers, {2} following", item.Key, item.Value.Followers.Count(), item.Value.Following.Count(), go);
                if (go == 1)
                {
                    foreach (var set in item.Value.Followers)
                    {
                        Console.WriteLine("*  {0}", set);
                    }
                   
                }
                go++;
            }
        }
    }

    class Vlog
    {
        public SortedSet<string> Followers { get; set; }

        public SortedSet<string> Following { get; set; }

        public Vlog()
        {
            this.Followers = new SortedSet<string>();
            this.Following = new SortedSet<string>();
        }
    }
}
