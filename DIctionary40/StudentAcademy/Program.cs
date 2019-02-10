using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> StudentGrades = new Dictionary<string, List<double>>();
            for (int i = 0; i < n; i++)
            {
                string Name = Console.ReadLine();
                double Grade = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

                if (StudentGrades.ContainsKey(Name))
                {
                    StudentGrades[Name].Add(Grade);
                }
                else
                {
                    StudentGrades.Add(Name, new List<double>());
                    StudentGrades[Name].Add(Grade);
                }

            }

            foreach (var item in StudentGrades.Where(x => x.Value.Average() >= 4.50).OrderByDescending(x => x.Value.Average()))
            {
                Console.WriteLine("{0} -> {1:f2}", item.Key, item.Value.Average());
            }

        }
    }
}
