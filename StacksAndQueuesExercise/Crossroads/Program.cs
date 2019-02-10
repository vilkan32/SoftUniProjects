using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {

            int durationofgreenlight = int.Parse(Console.ReadLine());

            int durationoffreewindow = int.Parse(Console.ReadLine());

            Queue<string> Cars = new Queue<string>();
            string currentCar = string.Empty;
            bool crashindicatior = false;
            int counter = 0;
            while (true)
            {

                string command = Console.ReadLine();
                if (command == "END")
                {
                    break;
                }

                if (command == "green")
                {


                    if (Cars.Any())
                    {
                        currentCar = Cars.Peek();
                        Queue<char> car = new Queue<char>(Cars.Dequeue());
                        counter++;
                        for (int i = 1; i <= durationofgreenlight; i++)
                        {
                            if (car.Any())
                            {
                                car.Dequeue();
                            }
                            else
                            {
                                if (Cars.Any())
                                {
                                    currentCar = Cars.Peek();
                                    car = new Queue<char>(Cars.Dequeue());
                                    car.Dequeue();
                                    counter++;
                                }
                                else
                                {
                                    break;
                                }
                            }

                        }
                        if (car.Any())
                        {
                            for (int i = 1; i <= durationoffreewindow; i++)
                            {
                                if (car.Any())
                                {
                                    car.Dequeue();
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                        if (car.Any())
                        {
                            Console.WriteLine("A crash happened!");
                            Console.WriteLine("{0} was hit at {1}.", currentCar, car.Dequeue());
                            crashindicatior = true;
                            break;
                        }
                    }
                   

                    
                }
                else
                {
                    Cars.Enqueue(command);
                }
            }

            if (!crashindicatior)
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine("{0} total cars passed the crossroads.", counter);

            }

        }
    }
}
