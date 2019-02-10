using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> Input = Console.ReadLine().ToLower().Split(new char[]{' ', '.', ',', ':', ';'
                , '(', ')', ']', '[', '"', '\'',
                '\\', '/', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            Input = Input.Distinct().ToList();
            List<string> Result = new List<string>();



            Result = Input.Where(words => words.Length < 5).ToList();


            //            foreach (var Word in Input)
            //           {
            //        int count = Word.Length;
            //if (count <= 3)
            //{
            //Result.Add(Word);
            //    }
            //}

            Result = Result.OrderBy(x => x).ToList();


            Console.WriteLine(string.Join(", ", Result));


        }
    }
}
