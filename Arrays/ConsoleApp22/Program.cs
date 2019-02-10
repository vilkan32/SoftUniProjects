using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] arr1 = new int[arr.Length + 2];
            arr1[0] = 0;
            int leftsum = 0;
            int rightsum = 0;
            arr1[arr.Length + 1] = 0;
            int index = 1;
            int broipreminavaniq = 0;
            for (int i = 1; i < arr.Length + 1; i++)
            {
                arr1[i] = arr[i - 1];
            }

            while (index+ 1 < arr1.Length)
            {

                for (int c = 0; c < index; c++)
                {
                  
                    leftsum += arr1[c];

                }
                for (int d = index + 1; d < arr1.Length - 1; d++)
                {
                    rightsum += arr1[d];

                }
                
                if (leftsum == rightsum)
                {

                    broipreminavaniq++;
                    Console.WriteLine(index - 1);
                        break;
                  
                    
                }
                else if (leftsum != rightsum && (leftsum != 0 || rightsum != 0))
                {
                    leftsum = 0;
                    rightsum = 0;
                    
                }
                index++;

            }


            if (arr.Length == 1 && broipreminavaniq <=0)
            {
                Console.WriteLine(0);
            }
            else if (leftsum == 0 && rightsum == 0 && broipreminavaniq <= 0)
            {
                Console.WriteLine("no");
            }
 
        }
    }
}
