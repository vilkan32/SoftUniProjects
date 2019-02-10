using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int dimensions = int.Parse(Console.ReadLine());

            string[] command = Console.ReadLine().Split(' ').ToArray();

            char[][] jagged = new char[dimensions][];
            int Row = 0;
            int Col = 0;
            int numberofCoals = 0;

            for (int row = 0; row < dimensions; row++)
            {
                char[] input = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
                jagged[row] = new char[dimensions];
                for (int col = 0; col < dimensions; col++)
                {
                    jagged[row][col] = input[col];
                    if (jagged[row][col] == 's')
                    {
                        Row = row;
                        Col = col;
                    }
                    if (jagged[row][col] == 'c')
                    {
                        numberofCoals++;
                    }
                }
            }
            bool gameover = false;
            int coals = 0;
            foreach (var item in command)
            {
                if (item == "up")
                {
                    if (Row - 1 >=0)
                    {
                        if (jagged[Row - 1][Col] == '*')
                        {
                            jagged[Row][Col] = '*';
                            Row = Row - 1;
                            jagged[Row][Col] = 's';
                            continue;
                        }
                        if (jagged[Row - 1][Col] == 'e')
                        {
                            Row = Row - 1;
                            gameover = true;
                            break;
                        }
                        if (jagged[Row - 1][Col] == 'c')
                        {
                            coals++;
                            jagged[Row][Col] = '*';
                            Row = Row - 1;
                            jagged[Row][Col] = 's';

                        }
                    }
                }

                if (item == "down")
                {
                    if (Row + 1 < dimensions)
                    {
                        if (jagged[Row + 1][Col] == '*')
                        {
                            jagged[Row][Col] = '*';
                            Row = Row + 1;
                            jagged[Row][Col] = 's';
                            continue;
                        }
                        if (jagged[Row + 1][Col] == 'e')
                        {
                            Row = Row + 1;
                            gameover = true;
                            break;
                        }
                        if (jagged[Row + 1][Col] == 'c')
                        {
                            coals++;
                            jagged[Row][Col] = '*';
                            Row = Row + 1;
                            jagged[Row][Col] = 's';
                        }
                    }
                }

                if (item == "left")
                {
                    if (Col - 1 >= 0)
                    {
                        if (jagged[Row][Col - 1] == '*')
                        {
                            jagged[Row][Col] = '*';
                            Col = Col - 1;
                            jagged[Row][Col] = 's';
                            continue;
                        }
                        if (jagged[Row][Col - 1] == 'e')
                        {
                            Col = Col - 1;
                            gameover = true;
                            break;
                        }
                        if (jagged[Row][Col - 1] == 'c')
                        {
                            coals++;
                            jagged[Row][Col] = '*';
                            Col = Col - 1;
                            jagged[Row][Col] = 's';

                        }
                    }
                }

                if (item == "right")
                {
                    if (Col + 1 < dimensions)
                    {
                        if (jagged[Row][Col + 1] == '*')
                        {
                            jagged[Row][Col] = '*';
                            Col = Col + 1;
                            jagged[Row][Col] = 's';
                            continue;
                        }
                        if (jagged[Row][Col + 1] == 'e')
                        {
                            Col = Col + 1;
                            gameover = true;
                            break;
                        }
                        if (jagged[Row][Col + 1] == 'c')
                        {
                            coals++;
                            jagged[Row][Col] = '*';
                            Col = Col + 1;
                            jagged[Row][Col] = 's';
                        }
                    }
                }
            }

            if (gameover)
            {
                Console.WriteLine("Game over! ({0}, {1})", Row,Col);
            }
            else
            {
                if (coals < numberofCoals)
                {
                    Console.WriteLine("{0} coals left. ({1}, {2})", numberofCoals - coals, Row, Col);
                }
                else
                {
                    Console.WriteLine("You collected all coals! ({0}, {1})", Row, Col);
                }
            }

           

        }
    }
}
