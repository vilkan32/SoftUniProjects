using System;
using System.Linq;

namespace BoxOfT
{
    class StartUp
    {   
        static void Main(string[] args)
        {
            BoxOfT.Tuple<string, string> tuple = new BoxOfT.Tuple<string, string>();
            string[] input = Console.ReadLine().Split(' ');
            tuple.ItemOne = input[0] + " " + input[1];
            tuple.ItemTwo = input[2];

            BoxOfT.Tuple<string, int> tuple1 = new BoxOfT.Tuple<string, int>();
            string[] input1 = Console.ReadLine().Split(' ');
            tuple1.ItemOne = input1[0];
            tuple1.ItemTwo = int.Parse(input1[1]);

            BoxOfT.Tuple<int, double> tuple2 = new BoxOfT.Tuple<int, double>();
            string[] input2 = Console.ReadLine().Split(' ');
            tuple2.ItemOne = int.Parse(input2[0]);
            tuple2.ItemTwo = double.Parse(input2[1]);


            Console.WriteLine(tuple.ItemOne + " -> "+  tuple.ItemTwo);
            Console.WriteLine(tuple1.ItemOne + " -> " + tuple1.ItemTwo);
            Console.WriteLine(tuple2.ItemOne + " -> " + tuple2.ItemTwo);
        }
    }
}
