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

            int n = int.Parse(Console.ReadLine());

            string trueresult = "";
            int opening = 0;
            int closing = 0;
            bool output = true;

            for (int i = 1; i <= n; i++)
            {
                string a = Console.ReadLine();

                if (a == "(")
                {
                    opening += 1;
                    trueresult += "(";
                }
                else if (a == ")")
                {
                    closing += 1;
                    trueresult += ")";
                }

                if (trueresult == "()")
                {
                   
                    trueresult = "";
                    continue;
                }
                else if (trueresult == ")(" || trueresult == "((" || trueresult == "))")
                {
                    output = false;
                    break;
                }
               



            }

            if (output && opening == closing)
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
