using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int current = int.MaxValue;
            string result = "";
            int broipreminavaniq = 0;
            int predishenbroipreminavaniq = 0;
            string predishenresult = "";
            for (int i = 0; i < arr.Length; i++)
            {
                current = arr[i];

                for (int c = i + 1; c < arr.Length; c++)
                {
                    if (arr[i] < arr[c] && arr[c] != arr[c - 1] && arr[c - 1] < arr[c])
                    {
                        broipreminavaniq++;
                        if (broipreminavaniq == 1)
                        {
                            result = string.Join(" ", arr[i]) + " ";
                        }
                        
                            result += string.Join(" ", arr[c]) + " ";
                        
                    }
                    else
                    {
                       
                     
                        break;
                    }
                }
                if (predishenbroipreminavaniq < broipreminavaniq)
                {
                    predishenresult = result;
                    predishenbroipreminavaniq = broipreminavaniq;
                }

                broipreminavaniq = 0;
                result = "";
               

            }

            if (predishenbroipreminavaniq > broipreminavaniq)
            {
                Console.WriteLine(predishenresult);
            }
            else
            {
                Console.WriteLine(result);
            }

        }
    }
}
