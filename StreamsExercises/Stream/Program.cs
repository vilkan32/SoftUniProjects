using System;
using System.Collections.Generic;
using System.IO;

namespace EvenLines
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var reader = new StreamReader("../../../text.txt"))
            {


                using (var writer = new StreamWriter("../../../result.txt"))
                {

                    string line = reader.ReadLine();
                    int counter = 0;
                    string symbols = ",-.!?";
                    List<string> output = new List<string>();

                    while (line != null)
                    {
                        string displayresult = string.Empty;
                        if (counter % 2 ==0)
                        {
                            foreach (var item in line)
                            {
                                if (symbols.Contains(item.ToString()))
                                {
                                    displayresult += '@';
                                }
                                else
                                {
                                    displayresult += item;
                                }
                            }
                            string[] result = displayresult.Split();

                            Array.Reverse(result);
                            output.Add(string.Join(" ", result));

                        }
                        counter++;
                        line = reader.ReadLine();
                    }

                    for (int i = 0; i < output.Count; i++)
                    {
                        if (i == output.Count - 1)
                        {
                            writer.Write(output[i]);
                        }
                        else
                        {
                            writer.WriteLine(output[i]);
                        }

                    }
                }
            }

        }
    }
}
