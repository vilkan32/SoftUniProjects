using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            string opCode = Console.ReadLine();
            long result = 0;
            while (opCode != "end")
            {
                string[] codeArgs = opCode.Split(' ');

                
                switch (codeArgs[0])
                {
                    case "INC":
                        {
                            long operandOne = long.Parse(Console.ReadLine());
                            try
                            {
                                operandOne = long.Parse(Console.ReadLine());
                            }
                            catch (Exception)
                            {

                             string ReadEnd = Console.ReadLine();
                                if (ReadEnd == "END")
                                {
                                    opCode = "END";
                                    break;
                                }
                            }
                            operandOne++;
                            result = operandOne;
                            break;
                        }
                    case "DEC":
                        {
                            long operandOne = long.Parse(Console.ReadLine());
                            try
                            {
                                operandOne = long.Parse(Console.ReadLine());
                            }
                            catch (Exception)
                            {

                                string ReadEnd = Console.ReadLine();
                                if (ReadEnd == "END")
                                {
                                    opCode = "END";
                                    break;
                                }
                            }
                            operandOne--;
                            result = operandOne;
                            break;
                        }
                    case "ADD":
                        {
                            long operandOne = long.Parse(Console.ReadLine());
                            long operandTwo = long.Parse(Console.ReadLine());
                            try
                            {
                                operandOne = long.Parse(Console.ReadLine());
                                operandTwo = long.Parse(Console.ReadLine());
                            }
                            catch (Exception)
                            {

                                string ReadEnd1 = Console.ReadLine();
                                if (ReadEnd1 == "END")
                                {
                                    opCode = "END";
                                    break;
                                }
                            }
                            

                            result = operandOne + operandTwo;
                            break;
                        }
                    case "MLA":
                        {
                            long operandOne = long.Parse(Console.ReadLine());
                            long operandTwo = long.Parse(Console.ReadLine());
                            try
                            {
                                operandOne = long.Parse(Console.ReadLine());
                                operandTwo = long.Parse(Console.ReadLine());
                            }
                            catch (Exception)
                            {

                                string ReadEnd1 = Console.ReadLine();
                                if (ReadEnd1 == "END")
                                {
                                    opCode = "END";
                                    break;
                                }
                            }


                            result = operandOne * operandTwo;
                            break;
                        }
                }

                Console.WriteLine(result);
            }
        }
    }
}
