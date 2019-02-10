using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string result = "";
            int i = 0;
            int broipreminavaniq = 0;
            int predishenbroipreminavaniq = 0;
            string predishenresult = "";

            for (int c = 1; c < arr.Length; c++)
            {

                if (arr[i] < arr[c])
                {
                    if (broipreminavaniq == 0)
                    {
                        result += string.Join(" ", arr[i]) + " ";
                        result += string.Join(" ", arr[c]) + " ";
                    }
                    else
                    {
                        result += string.Join(" ", arr[c]) + " ";
                    }
                    broipreminavaniq++;
                    
                    
                }
                else
                {
                    i++;
                    if (broipreminavaniq > predishenbroipreminavaniq)
                    {
                        predishenbroipreminavaniq = broipreminavaniq;

                        broipreminavaniq = 0;
                        predishenresult = result;
                        result = "";

                    }
                    else
                    {
                        result = "";
                        broipreminavaniq = 0;
                    }
                    continue;
                }
               
                i++;

            }

            if (broipreminavaniq <= predishenbroipreminavaniq)
            {
                Console.WriteLine(predishenresult);
            }
            else if (broipreminavaniq > predishenbroipreminavaniq)
            {
                Console.WriteLine(result);
            }
        }
    }
}
