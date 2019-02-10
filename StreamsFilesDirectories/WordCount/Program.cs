using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = new StreamReader(@"C:\Users\Acer\Desktop\Lab-Streams\04. CSharp-Advanced-Streams-Files-and-Directories-Lab-Resources\Resources\03. Word Count\words.txt");
            List<string> words = new List<string>();
            using (reader)
            {
                words = reader.ReadLine().Split(' ').ToList();
            }

            var readerText = new StreamReader(@"C:\Users\Acer\Desktop\Lab-Streams\04. CSharp-Advanced-Streams-Files-and-Directories-Lab-Resources\Resources\03. Word Count\text.txt");

            List<string> text = new List<string>();

            using (readerText)
            {
                string line = readerText.ReadLine();
                while (line != null)
                {
                    text.AddRange(line.Split(new char[] {',', '.', '?', '!', '-', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList());
                    line = readerText.ReadLine();
                }
            }

            Dictionary<string, int> WordsCount = new Dictionary<string, int>();
            WordsCount.Add(words[0], 0);
            WordsCount.Add(words[1], 0);
            WordsCount.Add(words[2], 0);

            foreach (var item in text)
            {
                if (WordsCount.ContainsKey(item.ToLower()))
                {
                    WordsCount[item.ToLower()]++;
                }
            }

            var writer = new StreamWriter(@"C:\Users\Acer\Desktop\Lab-Streams\04. CSharp-Advanced-Streams-Files-and-Directories-Lab-Resources\Resources\03. Word Count\Output.txt");

            using (writer)
            {
                foreach (var item in WordsCount.OrderByDescending(x => x.Value))
                {
                    writer.WriteLine("{0} - {1}", item.Key, item.Value);
                }
            }
        }
    }
}
