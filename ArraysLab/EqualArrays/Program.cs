using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> First = Console.ReadLine().Split(' ').Select(int.Parse).ToList();


            List<int> Second = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            if (First.SequenceEqual(Second))
            {
                Console.WriteLine("Arrays are identical. Sum: {0}", First.Sum());
            }
            else
            {
                for (int i = 0; i < First.Count(); i++)
                {
                    if (First[i]!= Second[i])
                    {
                        Console.WriteLine("Arrays are not identical. Found difference at {0} index",i);
                        break;
                    }
                }
                
            }
        }
    }
}
