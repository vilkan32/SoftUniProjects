using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            Student[] MultipleStudens = new Student[a];

            SortedDictionary<string, List<double>> NamesAverage = new SortedDictionary<string, List<double>>();
            MultipleStudens = ReturnStudent(MultipleStudens);
            NamesAverage = ReturnList(MultipleStudens);

            foreach (var item in NamesAverage)
            {
                if (item.Value.Count() > 1)
                {
                    List<double> sortedoutput = new List<double>();

                    for (int i = 0; i < item.Value.Count(); i++)
                    {
                        sortedoutput.Add(item.Value[i]);
                    }
                    sortedoutput.Sort();
                    sortedoutput.Reverse();
                    for (int i = 0; i < sortedoutput.Count; i++)
                    {
                        Console.WriteLine("{0} -> {1:f2}", item.Key,sortedoutput[i]);
                    }
                }
                else
                {
                    Console.WriteLine("{0} -> {1:f2}", item.Key, item.Value[0]);
                }
            }
          



        }
        public static SortedDictionary<string, List<double>> ReturnList(Student[] input)
        {
            SortedDictionary<string, List<double>> NamesAverage = new SortedDictionary<string, List<double>>();
            for (int i = 0; i < input.Length; i++)
            {
                if (!NamesAverage.ContainsKey(input[i].Name) && input[i].averagegrade >= 5.00)
                {
                    NamesAverage.Add(input[i].Name, new List<double>());
                }
                if (input[i].averagegrade >= 5.00)
                {
                    NamesAverage[input[i].Name].Add(input[i].averagegrade);
                }
            }

            return NamesAverage;


        }
        public static Student[] ReturnStudent(Student[] awaitinginput)
        {
            

            for (int i = 0; i < awaitinginput.Length; i++)
            {
                Student studentinput = new Student();
                awaitinginput[i] = studentinput;
            }

            return awaitinginput;
        }
    }

    class Student
    {

        string[] input = Console.ReadLine().Split(' ').ToArray();

        public string Name { get { return input[0]; } }
        public double[] grades { get { return Grades(input); } }
        public double averagegrade  { get { return Grades(input).Average(); }}
        public static double[] Grades(string[] awaitinginput)
        {
            List<double> grades = new List<double>();
            for (int i = 1; i < awaitinginput.Length ; i++)
            {
                grades.Add(Convert.ToDouble(awaitinginput[i]));
            }

            return grades.ToArray();
        }
 
    }
}
