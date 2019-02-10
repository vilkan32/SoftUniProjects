using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int a = 0;
            if (arr1.Length == arr2.Length)
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    int sum = arr1[i] + arr2[i];

                    Console.Write(sum + " ");
                }
            }
            else
            {
                if (arr1.Length > arr2.Length)
                {
                    for (int i = 0; i < arr1.Length; i++)
                    {

                        try
                        {
                            int sum = arr1[i] + arr2[i];
                            Console.Write(sum + " ");

                        }
                        catch (Exception)
                        {

                            if (a > arr2.Length - 1)
                            {
                                a = 0;
                            }
                            int sum = arr1[i] + arr2[a];
                            Console.Write(sum + " ");

                            if (a <= arr2.Length - 1)
                            {
                                a++;
                            }

                        }
                        
   
                    }
                }
                else if (arr1.Length < arr2.Length)
                {
                    for (int i = 0; i < arr2.Length; i++)
                    {

                        try
                        {
                            int sum = arr1[i] + arr2[i];
                            Console.Write(sum + " ");

                        }
                        catch (Exception)
                        {

                            if (a > arr1.Length - 1)
                            {
                                a = 0;
                            }
                            int sum = arr1[a] + arr2[i];
                            Console.Write(sum + " ");

                            if (a <= arr1.Length - 1)
                            {
                                a++;
                            }

                        }


                    }
                }
            }
        }
    }
}
