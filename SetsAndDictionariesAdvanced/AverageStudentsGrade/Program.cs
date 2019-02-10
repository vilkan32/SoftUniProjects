using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageStudentsGrade
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> StudentGrades = new Dictionary<string, List<double>>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                if (!StudentGrades.ContainsKey(input[0]))
                {
                    StudentGrades.Add(input[0], new List<double>());
                    StudentGrades[input[0]].Add(double.Parse(input[1]));
                }
                else
                {
                    StudentGrades[input[0]].Add(double.Parse(input[1]));
                }

            }

            foreach (var item in StudentGrades)
            {
                Console.Write(item.Key + " -> ");
                foreach (var cell in item.Value)
                {
                    Console.Write("{0:f2} ", cell);
                }
                Console.Write("(avg: {0:f2})", item.Value.Average());
                Console.WriteLine();
            }
        }
    }
}
