using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Sequence> SequenceList = new List<Sequence>();
            int ID = 0;
            var resultas = new Sequence();
            while (true)
            {
                ID++;
                string linesofinput = Console.ReadLine();
                if (linesofinput == "Clone them!")
                {

                    break;
                }
                int[] Numbers = new int[n];
                Sequence IndividualDNA = new Sequence();
                Numbers = linesofinput.Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                linesofinput = "";
                IndividualDNA.Numbers = Numbers.ToList();
                IndividualDNA.SumOfDigits = Numbers.Sum();
                for (int i = 0; i < n; i++)
                {
                    linesofinput += Numbers[i];
                }
                List<string> SubseqLength = linesofinput.Split(new char[] { '0' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                int count = 0;
                foreach (var item in SubseqLength)
                {


                    if (count < item.Count())
                    {
                        count = item.Count();
                    }
                }
                IndividualDNA.SubsequenceLength = count;
                string sequence = new string('1', count);
                int index = 0;
                if (count == 0)
                {

                }
                else
                {
                    var regex = new StringBuilder(linesofinput);

                    var result = regex.Replace(sequence, "a");
                    index = result.ToString().IndexOf('a');
                }
                IndividualDNA.LeftmostIndex = index;
                IndividualDNA.SampleID = ID;
                SequenceList.Add(IndividualDNA);

            }

            resultas = SequenceList.OrderByDescending(x => x.SubsequenceLength).ThenBy(y => y.LeftmostIndex).ThenByDescending(z => z.SumOfDigits).ElementAt(0);
            Console.WriteLine("Best DNA sample {0} with sum: {1}.", resultas.SampleID, resultas.SumOfDigits);
            Console.WriteLine(string.Join(" ", resultas.Numbers));

        }
        class Sequence
        {
            public List<int> Numbers { get; set; }
            public int SubsequenceLength { get; set; }
            public int SumOfDigits { get; set; }
            public int LeftmostIndex { get; set; }
            public int SampleID { get; set; }
            public Sequence()
            {
                Numbers = new List<int>();

            }


        }
    }
}