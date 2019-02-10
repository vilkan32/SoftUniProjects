using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalTry
{
    class Program
    {
        static void Main(string[] args)
        {

            Stack<char> snake = new Stack<char>(new char[] {'*', '*', '*', '*', '*' });
            
            for (int i = 0; i < 100; i++)
            {
                snake.Push('*');
                Console.Write(snake.Peek());
                
            }
        }
    }
}
