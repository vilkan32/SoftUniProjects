using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messaging
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> Input = Console.ReadLine().Split(' ').ToList();
            List<char> message = Console.ReadLine().ToList();               
            string chosenOne = "";
            for (int i = 0; i < Input.Count(); i++)
            {
                string number = Input[i];
                int index = 0;
                foreach (var item in number)
                {
                    index += Convert.ToInt32(item.ToString());
                }
               
                int currentindex = index;
                int removeat = 0;
                while (true)
                {
                    for (int x = 0; x < message.Count; x++)
                    {
                        if (currentindex == 0)
                        {
                            chosenOne += message[x];
                            removeat = x;
                            break;
                        }
                        currentindex--;
                    }
                    if (currentindex == 0)
                    {
                        break;
                    }
                }
                message.RemoveAt(removeat);
            }

           


            Console.WriteLine(chosenOne);
        }
    }
}
