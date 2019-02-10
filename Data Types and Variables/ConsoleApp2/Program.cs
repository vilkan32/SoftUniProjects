using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int numberofpreminavaniqzaopening = 0;
            int numberofpreminavaniqzaclosing = 0;
            bool output = true;
            for (int i = 1; i <= n; i++)
            {
                string read = Console.ReadLine();
               
                if (i % 2 == 0 && (read == "(" || read == ")"))
                {
                    int first = 0;
                    int second = 0;
                    if (read== "(")
                    {
                        first = 1;
                    }
                    else if (read == ")")
                    {
                        second = 2;
                    }
                    if (first == 2)
                    {
                        output = false;
                    }
                }
                

                if (i % 2 != 0 && (read == "(" || read == ")"))
                {
                    int first = 0;
                    int second = 0;
                    if (read == "(")
                    {
                        first = 1;
                    }
                    else if (read == ")")
                    {
                        second = 2;
                    }
                    if (second == 2)
                    {
                        output = false;
                    }
                }
                

            }

            if (output)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }



        }
    }
}
