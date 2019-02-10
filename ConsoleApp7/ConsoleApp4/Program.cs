using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            List<double> readlist = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            List<double> result = new List<double>();
           
                for (int i = 0; i < readlist.Count; i++)
                {

                    try
                    {
                        if (readlist[i] == readlist[i + 1])
                        {
                            double number = readlist[i];

                            result.Add(number * 2);
                            i++;
                        if (i == readlist.Count - 1)
                        {
                            i = -1;
                            readlist = result;
                            result = new List<double>();
                        }
                            continue;
                        }
                    }
                    catch (Exception)
                    {
                        result.Add(readlist[i]);
                        i = -1;
                        if (readlist.Count == result.Count)
                        {
                            break;
                        }
                        readlist = result;
                        result = new List<double>();

                        continue;
                    }

                    result.Add(readlist[i]);
                }

             Console.WriteLine(string.Join(" ",result));
        }
    }
}