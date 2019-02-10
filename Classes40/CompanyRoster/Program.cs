using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyRoster
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Employee> Result = new List<Employee>();
            Dictionary<string, List<double>> Calculate = new Dictionary<string, List<double>>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();

                Employee local = new Employee();
                local.Name = input[0];
                local.Salary = double.Parse(input[1]);
                local.Department = input[2];
                Result.Add(local);
            }
            foreach (var item in Result)
            {
                if (Calculate.ContainsKey(item.Department))
                {
                    Calculate[item.Department].Add(item.Salary);
                }
                else
                {
                    Calculate.Add(item.Department, new List<double>());
                    Calculate[item.Department].Add(item.Salary);
                }
            }
            string Department = "";
            foreach (var item in Calculate.OrderByDescending(x => x.Value.Average()))
            {
                Department = item.Key;
                break;
            }
            Console.WriteLine("Highest Average Salary: {0}", Department);
            foreach (var item in Result.Where(x => x.Department == Department).OrderByDescending(x => x.Salary))
            {
                Console.WriteLine("{0} {1:f2}", item.Name, item.Salary);
            }

        }

    }
       
    
    class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }
    }
}
