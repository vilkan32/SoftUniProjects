using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {


            List<int> Input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int numberofrotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberofrotations; i++)
            {
                List<int> RotatingList = new List<int>();
                int firstnumber = Input[0];
                for (int x = 1; x < Input.Count(); x++)
                {
                    RotatingList.Add(Input[x]);
                }
                RotatingList.Add(firstnumber);
                Input = RotatingList;
            }
            Console.WriteLine(string.Join(" ", Input));
        }
    }
}
