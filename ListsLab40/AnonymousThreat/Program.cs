using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> input = Console.ReadLine().Split(' ').ToList();

            while (true)
            {
                List<string> commands = Console.ReadLine().Split(' ').ToList();
                if (commands[0] == @"3:1")
                {
                    break;
                }
                List<string> rewrite = new List<string>();
                if (commands[0] == "merge")
                {
                    int startIndex = Convert.ToInt32(commands[1]);
                    int endIndex = Convert.ToInt32(commands[2]);

                    if (startIndex <= 0 && endIndex >= input.Count())
                    {
                        //-inf go +inf
                        string rewritten = "";
                        for (int i = 0; i < input.Count(); i++)
                        {
                            rewritten += input[i];
                        }
                        rewrite.Add(rewritten);
                        input = new List<string>();
                        input.Add(rewrite[0]);
                    }
                    else if (startIndex <= 0 && endIndex < input.Count())
                    {
                        string rewritten = "";
                        for (int i = 0; i <= endIndex; i++)
                        {
                            rewritten += input[i];
                        }
                        rewrite.Add(rewritten);
                        for (int i = endIndex + 1; i < input.Count(); i++)
                        {
                            rewrite.Add(input[i]);
                        }
                        input = new List<string>();
                        input.AddRange(rewrite);
                    }
                    else if (startIndex >= 0 && startIndex < input.Count())
                    {
                        if (endIndex >= input.Count())
                        {
                            for (int i = 0; i < startIndex; i++)
                            {
                                rewrite.Add(input[i]);
                            }
                            string tobeadded = "";
                            for (int i = startIndex; i < input.Count(); i++)
                            {
                                tobeadded += input[i];
                            }
                            rewrite.Add(tobeadded);
                            input = new List<string>();
                            input.AddRange(rewrite);
                        }
                        else
                        {
                            for (int i = 0; i < startIndex; i++)
                            {
                                rewrite.Add(input[i]);
                            }
                            string tobeadded = "";
                            for (int i = startIndex; i <= endIndex; i++)
                            {
                                 tobeadded += input[i];
                            }
                            rewrite.Add(tobeadded);
                            for (int i = endIndex + 1; i < input.Count(); i++)
                            {
                                rewrite.Add(input[i]);
                            }
                            input = new List<string>();
                            input.AddRange(rewrite);
                        }
                    }
                }
                else if (commands[0] == "divide")
                {
                    List<char> tobemanipulated = input[Convert.ToInt32(commands[1])].ToList();
                    int count = Convert.ToInt32(commands[2]);
                    int numOfchar = tobemanipulated.Count() / Convert.ToInt32(commands[2]);
                    string single = "";
                    List<string> rewritten = new List<string>();
                    for (int i = 0; i < tobemanipulated.Count(); i++)
                    {
                        single += tobemanipulated[i];
                        if (rewritten.Count() == count -1)
                        {
                           
                            continue;

                        }
                        if (single.Length == numOfchar)
                        {
                            rewritten.Add(single);
                            single = "";
                        }


                    }
                    if (single != "")
                    {
                        rewritten.Add(single);
                    }

                    input.RemoveAt(Convert.ToInt32(commands[1]));

                    input.InsertRange(Convert.ToInt32(commands[1]), rewritten);


                }
            }
            Console.WriteLine(string.Join(" ", input));

        }
    }
}
