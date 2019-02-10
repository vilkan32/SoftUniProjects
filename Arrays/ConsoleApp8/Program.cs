using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] arr2 = new int[arr1.Length];
            int broipreminavaniq = 0;
           

            while (arr2.Length > 1)
            {
                broipreminavaniq++;
             
                for (int i = 0; i <= arr1.Length - 1; i++)
                {

                    try
                    {
                        arr2[i] = arr1[i] + arr1[i + 1];
                    }
                    catch (Exception)
                    {

                        
                    }
                   
                                                
                }
                Array.Resize<int>(ref arr2, arr2.Length - 1);
                for (int r = 0; r < arr2.Length; r++)
                {
                    arr1[r] = arr2[r];
                }
                Array.Resize<int>(ref arr1, arr1.Length - 1);
            }
            if (broipreminavaniq == 0)
            {

                Console.WriteLine(arr1[0] + " is already condensed to number");
                
            }
            else
            {
                Console.WriteLine(arr1[0]);
            }

        }
    }
}
