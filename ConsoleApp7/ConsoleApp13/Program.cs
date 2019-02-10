using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> Input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> Output = new List<int>();
            List<int> exOutput = new List<int>();
            int counter = 0;
            int firstim = 0;
            int broipreminavaniq = 0;

            for (int i = 0; i < Input.Count; i++)
            {
                
                for (int c = i + 1; c < Input.Count; c++)
                {
                    firstim = Input[i];
                   
                    if (firstim < Input[c])
                    {
                        if (counter > 0)
                        {
                            i += counter + 1;
                            counter = 0;
                        }
                        else
                        {

                        }
                        {
                            i++;
                        }
                        Output.Add(Input[c]);
                        
                    }
                    else
                    {
                        counter++; 
                    }
                   
                }
                
                counter = 0;
                Output.Insert(broipreminavaniq, Input[broipreminavaniq]);
                broipreminavaniq++;
                if (exOutput.Count < Output.Count)
                {
                    exOutput = Output;
                }
                Output = new List<int>();
                i = broipreminavaniq - 1;
            }


        }
    }
}
