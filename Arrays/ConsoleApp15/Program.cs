using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arr1 = new int[arr.Length];
            int broipreminavaniq = 0;
            int predishenbroip = 0;
            string result = "";
            string predishen = "";
            
           

            for (int i = 0; i < arr.Length; i++)
            {


                for (int c = 1; c < arr1.Length; c++)
                {
                    try
                    {
                        if (arr[i] == arr[c])
                        {
                            broipreminavaniq++;
                            result += string.Join(" ", arr[i]) + " ";
                        }
                        else if (arr[i] != arr1[i + 1] && predishenbroip < broipreminavaniq)
                        {
                            predishen = result;
                            predishenbroip = broipreminavaniq;
                            broipreminavaniq = 0;
                            result = "";
                            break;

                        }
                    }
                    catch (Exception)
                    {

                        break;
                    }
                }

            }

            if (predishenbroip > broipreminavaniq)
            {
                string[] result1 = predishen.Split(' ').ToArray();
                Array.Resize(ref result1, result1.Length);
                string a = result1[0];

                for (int i = 0; i < result1.Length; i++)
                {
                    result1[i] = a;
                }
                predishen = string.Join(" ", result1);

                Console.WriteLine(predishen);
            }
            else if (broipreminavaniq == predishenbroip)
            {
                string[] result1 = predishen.Split(' ').ToArray();
                Array.Resize(ref result1, result1.Length);
                string a = result1[0];

                for (int i = 0; i < result1.Length; i++)
                {
                    result1[i] = a;
                }
                predishen = string.Join(" ", result1);

                Console.WriteLine(predishen);
            }
            else
            {
                string[] result1 = result.Split(' ').ToArray();
                Array.Resize(ref result1, result1.Length );

                string a = result1[0];

                for (int i = 0; i < result1.Length; i++)
                {
                    result1[i] = a;
                }
                result = string.Join(" ", result1);

                Console.WriteLine(result);
            }
        }
    }
}
