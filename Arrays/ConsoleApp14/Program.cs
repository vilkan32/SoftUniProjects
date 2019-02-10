using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            char[]arr1 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            string result = "";
            for (int i = 0; i < Math.Min(arr.Length, arr1.Length); i++)
            {
                if (arr[i] < arr1[i])
                {
                    if (arr.Length == arr1.Length)
                    {
                        result = string.Join("", arr);
                        Console.WriteLine(result);
                        result = string.Join("", arr1);
                        Console.WriteLine(result);
                        break;
                    }
                   
                }
                else if (arr[i] > arr1[i])
                {
                    if (arr.Length == arr1.Length)
                    {
                        result = string.Join("", arr1);
                        Console.WriteLine(result);
                        result = string.Join("", arr);
                        Console.WriteLine(result);
                        break;
                    }
                }
                else if (arr[i] == arr1[i] && arr.Length == arr1.Length)
                {
                    result = string.Join("", arr);
                    Console.WriteLine(result);
                    result = string.Join("", arr1);
                    Console.WriteLine(result);
                    break;
                }
                else if (arr[i] == arr1[i] && arr.Length < arr1.Length)
                {
                    result = string.Join("", arr);
                    Console.WriteLine(result);
                    result = string.Join("", arr1);
                    Console.WriteLine(result);
                    break;
                }
                else if (arr[i] == arr1[i] && arr.Length > arr1.Length)
                {
                    result = string.Join("", arr1);
                    Console.WriteLine(result);
                    result = string.Join("", arr);
                    Console.WriteLine(result);
                    break;
                }
            }



        }
    }
}
