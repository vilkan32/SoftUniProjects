using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {

            Library test = new Library();
            test.Books = new List<Books>();
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                
                string[] intput = Console.ReadLine().Split(' ').ToArray();
                Books test1 = new Books(intput[0], intput[1], intput[2], intput[3], intput[4], intput[5]);

                test.Books.Add(test1);
                
            }
            string date = Console.ReadLine();
            string format = "dd.MM.yyyy";
            DateTime Date = DateTime.ParseExact(date, format, System.Globalization.CultureInfo.InvariantCulture);

            var ordered = test.Books.Where(x => x.releasedate > Date).OrderBy(x => x.releasedate).ThenBy(x => x.title);

            foreach (var item in ordered)
            {
                Console.WriteLine("{0} -> {1:dd.MM.yyyy}", item.title, item.releasedate);
            }
            /*
                 var ordered = test.Books.GroupBy(x => x.author)
                                          .Select(g => new
                                          {
                                              Author = g.Key,
                                              Prices = g.Sum(s => s.price)
                                          })
                                          .OrderByDescending(x => x.Prices)
                                          .ThenBy(x => x.Author)
                                          .ToList();

              foreach (var item in ordered)
              {
                  Console.WriteLine("{0} -> {1:F2}", item.Author,item.Prices);
              }
              

            SortedDictionary<string, double> AuthorPrice = new SortedDictionary<string, double>();

            for (int i = 0; i < test.Books.Count(); i++)
            {
                if (!AuthorPrice.ContainsKey(test.Books[i].author))
                {
                    AuthorPrice.Add(test.Books[i].author, 0);
                }
                AuthorPrice[test.Books[i].author] += test.Books[i].price;
            }


            var something = AuthorPrice.OrderByDescending(x => x.Value).ThenBy(x => x.Key);

            foreach (var item in something)
            {
                Console.WriteLine("{0} -> {1:F2}", item.Key, item.Value);
            }
            */



            
        }

    }

      class Library
      {
          public string Name { get; set; }
          public List<Books> Books { get; set; }
      }

      class Books
      {
          public string title { get; set; }
          public string author { get; set; }
          public string publisher { get; set; }
          public DateTime releasedate { get; set; }
          public string ISBN { get; set; }
          public double price { get; set; }
          string format = "dd.MM.yyyy";
           public Books(string title, string author, string publisher, string releasedate, string ISBN, string price)
           {
              this.title = title;
              this.author = author;
              this.publisher = publisher;
              this.releasedate =  DateTime.ParseExact(releasedate, format, System.Globalization.CultureInfo.InvariantCulture);
              this.ISBN = ISBN;
              this.price = Convert.ToDouble(price);

           }



      }


  }
