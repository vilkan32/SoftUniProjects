using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int sum = arr[0];
            int currentindex = 0;
            int Currentnumber = arr[0]; // 2

            for (int i = 0; i < arr.Length; i++)
            {
               
                
                try
                {
                    
                    currentindex += Currentnumber;
                    Currentnumber = arr[currentindex];
                    sum += arr[currentindex];
                    
                }
                catch (Exception)
                {

                    try
                    {
                        currentindex =  currentindex - Currentnumber;
                        currentindex -= Currentnumber;
                        Currentnumber = arr[currentindex];
                        sum += arr[currentindex];
                    }
                    catch (Exception)
                    {

                        break;
                    }
                }


            }
            Console.WriteLine(sum);





        }
    }
}
