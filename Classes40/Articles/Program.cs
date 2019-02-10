using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Article> Statii = new List<Article>();
            int a = int.Parse(Console.ReadLine());
            // title}, {content}, {author}").
            for (int i = 0; i < a; i++)
            {
                string[] input = Console.ReadLine().Split(", ").ToArray();
                Article lolcal = new Article();
                lolcal.Title = input[0];
                lolcal.Content = input[1];
                lolcal.Author = input[2];
                Statii.Add(lolcal);

            }
            string order = Console.ReadLine();
            if (order.ToLower() == "title")
            {
                foreach (var item in Statii.OrderBy(x => x.Title))
                {
                    Console.WriteLine("{0} - {1}: {2}", item.Title, item.Content, item.Author);
                }
            }
            else if (order.ToLower() == "content")
            {
                foreach (var item in Statii.OrderBy(x => x.Content))
                {
                    Console.WriteLine("{0} - {1}: {2}", item.Title, item.Content, item.Author);
                }
            }
            else if (order == "author")
            {
                foreach (var item in Statii.OrderBy(x => x.Author))
                {
                    Console.WriteLine("{0} - {1}: {2}", item.Title, item.Content, item.Author);
                }
            }
           
        }
    }
    class Article
    {     
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
    }
}
