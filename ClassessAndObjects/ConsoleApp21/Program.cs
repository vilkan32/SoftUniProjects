using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            MyException Exc = new MyException();
            while (true)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 0)
                {
                    try
                    {
                        throw Exc;
                    }
                    catch (MyException)
                    {

                        Console.WriteLine(Exc.Message);
                    }
                                   
                }
                else
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
    class MyException : Exception
    {
        
        public MyException() : base("My first exception is awesome!!!")
        {

        }
     
        
    }
}
