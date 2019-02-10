using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();


            List<int> result = new List<int>();


            for (int i = 0; i < list.Count; i++)
            {

                try
                {
                    if (list[i] == list[i + 1])
                    {
                        result.Add(list[i] * 2);

                    }
                    else
                    {
                        result.Add(list[i + 1]);
                    }
                }
                catch (Exception)
                {

                    list = result;
                    i = -1;
                    result = new List<int>();
                }
                if (list.Count <= 2 && result.Count < 2)
                {
                    break;
                }
                
            }

            Console.WriteLine(String.Join(" ", list));




        }
    }
}
