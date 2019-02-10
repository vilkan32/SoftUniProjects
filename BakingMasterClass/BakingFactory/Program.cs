using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakingFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Bread> TheBaker = new List<Bread>();
            while (true)
            {
                Bread current = new Bread();
                try
                {
                    List<int> Bakery = Console.ReadLine().Split('#').Select(int.Parse).ToList();
                    current.TheList = Bakery;
                    current.length = Bakery.Count();
                    current.Quality = Bakery.Sum();
                    current.Average = Bakery.Average();
                    TheBaker.Add(current);
                   
                }
                catch (Exception)
                {

                    break;
                }
            }

            foreach (var item in TheBaker.OrderByDescending(x => x.Quality).ThenByDescending(x => x.Average).ThenBy(x => x.length))
            {
                Console.WriteLine("Best Batch quality: {0}", item.Quality);
                Console.WriteLine(string.Join(" ", item.TheList));
                break;
            }
        }
    }
    class Bread
    {
        public  List<int> TheList { get; set; }
        public int Quality { get; set; }
        public double Average { get; set; }
        public int length { get; set; }

    }
}
