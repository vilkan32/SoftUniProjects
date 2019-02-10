using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int IndexSize = int.Parse(Console.ReadLine());

            long[] IndexesContainingBugs = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            Dictionary<long, long> pairs = new Dictionary<long, long>();

            for (int i = 0; i < IndexSize; i++)
            {
                pairs.Add(i, 0);
            }

            for (int i = 0; i < IndexesContainingBugs.Length; i++)
            {
                if (pairs.ContainsKey(IndexesContainingBugs[i]))
                {
                    pairs[IndexesContainingBugs[i]] = 1;
                }
            }

            while (true)
            {
                List<string> Input = Console.ReadLine().Split(' ').ToList();
                if (Input[0] == "end")
                {
                    break;
                }
                long index = Convert.ToInt64(Input[0].ToString());
                string direction = Input[1];
                long timestomove = Convert.ToInt64(Input[2].ToString());

                if (direction == "left")
                {
                    if (pairs.ContainsKey(index) && pairs[index] == 1)
                    {
                        bool cancontinue = false;
                        long newindex = 0;
                        if (timestomove == 0)
                        {
                            continue;
                        }
                        for (long i = index; i >= 0; i -= timestomove)
                        {
                            if (i == index)
                            {
                                continue;
                            }

                            if (pairs.ContainsKey(i) && pairs[i] == 0)
                            {
                                cancontinue = true;
                                newindex = i;
                                break;
                            }
                            else if (!pairs.ContainsKey(i) && (i < 0 || i > IndexSize))
                            {
                                break;
                            }
                        }

                        if (cancontinue == true)
                        {
                            pairs[index] = 0;
                            pairs[newindex] = 1;
                        }
                        else
                        {
                            pairs[index] = 0;
                        }

                    }
                }
                if (direction == "right")
                {
                    if (pairs.ContainsKey(index) && pairs[index] == 1)
                    {
                        bool cancontinue = false;
                        long newindex = 0;
                        if (timestomove == 0)
                        {
                            continue;
                        }
                        for (long i = index; i < IndexSize; i+=timestomove)
                        {
                            if (i == index)
                            {
                                continue;
                            }

                            if (pairs.ContainsKey(i) && pairs[i] == 0)
                            {
                                cancontinue = true;
                                newindex = i;
                                break;
                            }
                            else if (!pairs.ContainsKey(i) && (i < 0 || i > IndexSize))
                            {
                                break;
                            }
                        }
                        
                        if (cancontinue == true)
                        {
                            pairs[index] = 0;
                            pairs[newindex] = 1;
                        }
                        else
                        {
                            pairs[index] = 0;
                        }

                    }
                }
            }

            Console.WriteLine(string.Join(" ", pairs.Values.ToArray()));
        }
    }
}
