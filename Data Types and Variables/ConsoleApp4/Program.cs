using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int openingbracket = 0;
            int closingbracket = 0;
            bool result = true;
            int porednopreminavaneopening = 0;
            int porednopreminavaneclosing = 0;
            

            for (int i = 1; i <= n; i++)
            {
                string a = Console.ReadLine();

                try
                {
                    Convert.ToChar(a);
                }
                catch (Exception)
                {

                    continue;
                }

                if (a == "(")
                {

                    
                    porednopreminavaneopening += 1;
                    
                }
                else if (a == ")")
                {
                    
                    porednopreminavaneclosing += 1;
                   
                }

                if (porednopreminavaneopening == porednopreminavaneclosing)
                {
                    result = true;
                    


                }
                else if ( porednopreminavaneclosing != porednopreminavaneopening)
                {
                    result = false;
                    
                }
               
            }

            if (result)
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
