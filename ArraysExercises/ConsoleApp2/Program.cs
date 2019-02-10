using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequence
{
    class Program
    {
        static void Main(string[] args)
        {



            List<int> Input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string fillfromtemp = "";
            for (int i = 0; i < Input.Count(); i++)
            {
                int firstnum = Input[i];
                string temp = "";
                
                for (int x = i; x < Input.Count(); x++)
                {
                    if (firstnum == Input[x])
                    {
                        temp += firstnum + " ";
                    }
                    else
                    {
                        break;
                    }

                    
                }
                if (fillfromtemp.Length < temp.Length)
                {
                    fillfromtemp = temp;
                }
            }
            Console.WriteLine(fillfromtemp.TrimEnd());
        }
    }
}
