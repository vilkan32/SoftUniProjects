using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] arr = Console.ReadLine().Split(' ').ToArray();



            string command = "";
            while (true)
            {
                 command = Console.ReadLine();
                string[] arr1 = command.Split(' ').ToArray();
                if (command == "END")
                {
                    break;
                }
                if (command == "Reverse")
                {


                    Array.Reverse(arr);

                }
                else if (command == "Distinct")
                {
                    string[] newarr = arr.Distinct().ToArray();

                    arr = newarr;


                }
                else if(arr1[0] == "Replace")
                {
                    

                    string number = arr1[1];

                    int realnumber = Convert.ToInt32(number);

                    try
                    {
                        arr[realnumber] = arr1[2];

                    }
                    catch (Exception)
                    {

                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
               

            }
                

                for (int i = 0; i < arr.Length; i++)
                {
                if (i == arr.Length - 1)
                  {
                     Console.Write(arr[i]);
                   }
                else
                  {
                    Console.Write(arr[i] + ", ");
                   }
                }

            Console.WriteLine();

        }

       

    }
}
