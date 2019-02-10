using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvMessage
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] Phrases = { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product."};

            string[] Events = {"Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"};

            string[] Authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            string[] Cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            int n = int.Parse(Console.ReadLine());

            Random phrases = new Random();
            Random events = new Random();
            Random authors = new Random();
            Random towns = new Random();

            for (int i = 0; i < n; i++)
            {
                
                Console.WriteLine("{0} {1} {2} - {3}", Phrases[phrases.Next(0, Phrases.Length)], Events[events.Next(0, Phrases.Length)], Authors[authors.Next(0, Authors.Count())], Cities[towns.Next(0, Cities.Count())]);
            }
        }
    }
}
