using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            string Username = Console.ReadLine();
            List<char> Password = Username.ToList();
            Password.Reverse();
            string password = string.Join("", Password);
            int counter = 0;
            while (true)
            {
                string input = Console.ReadLine();
                counter++;
                if (counter == 4)
                {
                    Console.WriteLine("User {0} blocked!", Username);
                    break;
                }
                if (input == password)
                {
                    Console.WriteLine("User {0} logged in.", Username);
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                    continue;
                }
            }

        }
    }
}
