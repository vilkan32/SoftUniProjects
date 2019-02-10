using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            string[] phrases = new string[]
            { "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product." };

            string[] events = new string[] { "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!" };
            string[] authors = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            string[] towns = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random Phrases = new Random();
            Random Events = new Random();
            Random Authors = new Random();
            Random Towns = new Random();

            for (int i = 1; i <= a; i++)
            {

                int indexphrases = Phrases.Next(0, phrases.Length);
                int indexevents = Events.Next(0, events.Length);
                int indexauthors = Authors.Next(0, authors.Length);
                int indextowns = Towns.Next(0, towns.Length);

                Console.WriteLine("{0} {1} {2} - {3}", phrases[indexphrases], events[indexevents], authors[indexauthors], towns[indextowns]);

            }






        }
    }
}
