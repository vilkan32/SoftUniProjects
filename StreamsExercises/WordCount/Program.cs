using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> wordsCount = new Dictionary<string, int>();

            using (var wordsReader = new StreamReader("../../../words.txt"))
            {
                string words = wordsReader.ReadLine().ToLower(); // po uslovie ima 1 duma na 1 red vuv videoto praviha nqkakvi modifikacii na zadachata za mene ima 1 duma na 1 red i tva e nqma da splitvam nishto i si karam po zadachata
                while (words != null)
                {
                    if (!wordsCount.ContainsKey(words))
                    {
                        wordsCount.Add(words, 0);
                    }
                    words = wordsReader.ReadLine();
                }

            }
            // programata shte raboti ako vuv words.txt dumite sa po 1 na red !!!!
            using (var textReader = new StreamReader("../../../text.txt"))
            {
                
                while (true)
                {
                    string line = textReader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    string[] Line = line.Split(new char[] {'.', ',', '!', '?', ' ', '-'}, StringSplitOptions.RemoveEmptyEntries);                 
                    foreach (var item in Line)
                    {
                        if (wordsCount.ContainsKey(item.ToLower()))
                        {
                            wordsCount[item.ToLower()]++;
                        }
                    }
                }            

            }
            bool sameContent = true;
            using (var expecterResult = new StreamReader("../../../expectedResult.txt")) // izpisvam na konzolata dali expectedResult.txt contenta e kato kvp vuv wordsCount = new Dictionary<string, int>(); kudeto pazq dumite i kolko puti se sreshtat i ako rezultata e true i 2ta faila sa ednakvi togava zapisvam v nov fail rezultata
            {
                

                foreach (var item in wordsCount.OrderByDescending(x => x.Value))
                {
                    string comparison = item.Key + " - " + item.Value;
                    string line = expecterResult.ReadLine();

                    if (comparison != line)
                    {
                        sameContent = false;
                        break;
                    }

                }

            }

            if (sameContent)
            {
                Console.WriteLine(true);
                using (var writer = new StreamWriter("../../../actualResult.txt"))
                {
                    int count = 0;
                    foreach (var kvp in wordsCount.OrderByDescending(x => x.Value))
                    {
                        if (count == wordsCount.Count - 1)
                        {
                            writer.Write(kvp.Key + " - " + kvp.Value);
                        }
                        else
                        {
                            writer.WriteLine(kvp.Key + " - " + kvp.Value);
                        }
                        
                        count++;
                    }
                }

            }
        }
    }
}
