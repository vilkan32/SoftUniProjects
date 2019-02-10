using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> BannedWords = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            string Text = Console.ReadLine();

            foreach (var item in BannedWords)
            {
                if (Text.Contains(item))
                {
                    Text = Text.Replace(item, new string('*', item.Length));
                }
            }
            Console.WriteLine(Text);


        }
    }
}
