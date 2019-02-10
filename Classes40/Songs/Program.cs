using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Songs> Pesni = new List<Songs>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split('_').ToArray();
                Songs local = new Songs();
                local.List = input[0];
                local.Name = input[1];
                Pesni.Add(local);
            }

            string list = Console.ReadLine();
            if (list == "all")
            {
                foreach (var item in Pesni)
                {
                    Console.WriteLine(item.Name);
                }
            }
            else
            {
                foreach (var item in Pesni.Where(x => x.List == list))
                {
                    Console.WriteLine(item.Name);
                }
            }
        }
    }
    class Songs
    {
        public string List { get; set; }
        public string Name { get; set; }
    }
}
