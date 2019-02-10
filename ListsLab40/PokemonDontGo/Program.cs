using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDontGo
{
    class Program
    {
        static void Main(string[] args)
        {


            List<int> Input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> NumbersTakenByForce = new List<int>();

            while (true)
            {
                if (Input.Count() == 0)
                {
                    break;
                }
                int index = int.Parse(Console.ReadLine());
                int numberfromthelist = 0;
              
                if (index < 0)
                {
                    numberfromthelist = Input[0];
                    Input.RemoveAt(0);
                    index = 0;
                    Input.Insert(0, Input[Input.Count() - 1]);
                }
                else if (index > Input.Count() - 1)
                {
                    numberfromthelist = Input[Input.Count() - 1];
                    Input.RemoveAt(Input.Count() - 1);
                   
                    Input.Add(Input[0]);

                }
                else
                {
                    numberfromthelist = Input[index];
                    Input.RemoveAt(index);
                }
                
                NumbersTakenByForce.Add(numberfromthelist);
               
                for (int i = 0; i < Input.Count(); i++)
                {
                    if (Input[i] <= numberfromthelist)
                    {
                        Input[i] = Input[i] + numberfromthelist;
                    }
                    else
                    {
                        Input[i] = Input[i] - numberfromthelist;
                    }
                }
            }

            Console.WriteLine(NumbersTakenByForce.Sum());
        }
    }
}
