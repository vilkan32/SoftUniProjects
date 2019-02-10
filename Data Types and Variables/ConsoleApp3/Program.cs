using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int purvopreminavane = 0;
            int vroropreminavane = 0;

            bool result = true;
            for (int i = 1; i <= n; i++)
            {

                string read = Console.ReadLine();


                if (i % 2 != 0 && (read == ")" || read == "("))
                {
                    if (read == "(")
                    {
                        purvopreminavane = i;
                    }
                    else if (read == ")")
                    {
                        vroropreminavane = i;
                    }

                    if (vroropreminavane - purvopreminavane == 2)
                    {
                        result = true;
                        purvopreminavane = 0;
                        vroropreminavane = 0;
                    }
                    else if (vroropreminavane - purvopreminavane != 2 && purvopreminavane != 0 && vroropreminavane != 0)
                    {
                        result = false;
                        purvopreminavane = 0;
                        vroropreminavane = 0;
                    }
                   

                    
                }
                else if (i % 2 == 0 && (read == ")" || read == "("))
                {

                    if (read == "(")
                    {
                        purvopreminavane = i;
                    }
                    else if (read == ")")
                    {
                        vroropreminavane = i;
                    }

                    if (vroropreminavane - purvopreminavane == 2)
                    {
                        result = true;
                        purvopreminavane = 0;
                        vroropreminavane = 0;
                    }
                    else if (vroropreminavane - purvopreminavane != 2 && purvopreminavane != 0 && vroropreminavane != 0)
                    {
                        result = false;
                        purvopreminavane = 0;
                        vroropreminavane = 0;
                    }


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
