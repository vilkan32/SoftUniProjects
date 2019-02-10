using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {


            List<string> Input = Console.ReadLine().Split(' ').ToList();
            List<string> twodigitsonly = new List<string>();

            for (int i = 0; i < Input.Count; i++)
            {
                if (Input[i].Count() != 2)
                {

                }
                else
                {
                    twodigitsonly.Add(Input[i]);
                }
            }

            List<string> ReversedDigits = new List<string>();
            
            
            for (int i = 0; i < twodigitsonly.Count; i++)
            {
                string input = "";
                List<char> listofdigitsttoreverse = new List<char>();
                listofdigitsttoreverse = twodigitsonly[i].ToList();
                listofdigitsttoreverse.Reverse();
                input = listofdigitsttoreverse[0].ToString() + listofdigitsttoreverse[1].ToString();
                ReversedDigits.Add(input);
            }
            ReversedDigits.Reverse();
            for (int i = 0; i < ReversedDigits.Count; i++)
            {
                string element = Convert.ToChar(Convert.ToUInt32(ReversedDigits[i], 16)).ToString();
                Console.Write(element);
            }
            Console.WriteLine();
        }
    }
}
