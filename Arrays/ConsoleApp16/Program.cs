using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int num = int.MaxValue;
            int broipreminavaniq = 0;
            string result = "";
            int predishen = int.MaxValue;
            int predishenbroipreminavaniq = 0;
            string exresult = "";

            for (int i = 0; i < arr.Length; i++)
            {
                num = arr[i];
                if (num == predishen)
                {
                    continue;
                }


                for (int ci = i; ci < arr.Length; ci++)
                {
                  
                    if (num == arr[ci])
                    {
                        result += string.Join(" ", arr[ci] + " ");
                        predishen = num;
                        broipreminavaniq++;
                    }
                    else
                    {
                        predishen = num;
                        
                        if (predishenbroipreminavaniq < broipreminavaniq)
                        {
                            exresult = result;
                        }
                        
                        result = "";
                        if (predishenbroipreminavaniq < broipreminavaniq)
                        {
                            predishenbroipreminavaniq = broipreminavaniq;
                        }
                        broipreminavaniq = 0;
                        break;
                    }
                }

            }

            if (broipreminavaniq > predishenbroipreminavaniq)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(exresult);
            }
        }
    }
}
