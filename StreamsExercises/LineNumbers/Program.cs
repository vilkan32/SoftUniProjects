using System;
using System.Collections.Generic;
using System.IO;

namespace LineNumbers
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
                    int counter = 1;
                    List<string> outputResult = new List<string>();
                    string punctuation = ".,-!?'";
                    while (line != null)
                    {
                        int punctuationSymbols = 0;
                        int alphabeticSymbols = 0;

                        foreach (var item in line)
                        {
                            if (punctuation.Contains(item.ToString()))
                            {
                                punctuationSymbols++;
                            }
                            else if(item != ' ')
                            {
                                alphabeticSymbols++;
                            }
                        }
                        outputResult.Add($"Line {counter}: {line} ({alphabeticSymbols})({punctuationSymbols})");
                        line = reader.ReadLine();
                        counter++;
                    }

                    for (int i = 0; i < outputResult.Count; i++)
                    {
                        if (outputResult.Count - 1 == i)
                        {
                            writer.Write(outputResult[i]);
                        }
                        else
                        {
                            writer.WriteLine(outputResult[i]);
                        }
                    }
                }
            }
        }
    }
}
