using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MutantVampireBunny
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            char[][] jagged = new char[dimensions[0]][];

            int Row = 0;
            int Col = 0;
            for (int row = 0; row < dimensions[0]; row++)
            {
                string input = Console.ReadLine();
                jagged[row] = new char[dimensions[1]];
                for (int col = 0; col < dimensions[1]; col++)
                {
                    jagged[row][col] = input[col];

                    if (jagged[row][col] == 'P')
                    {
                        Row = row;
                        Col = col;
                    }
                }
            }
            string command = Console.ReadLine();
            bool gameover = false;
            bool wonTheGame = false;
            foreach (var item in command)
            {
                if (item == 'U')
                {
                    if (Row - 1 >= 0)
                    {
                        if (jagged[Row - 1][Col] == '.')
                        {
                            jagged[Row][Col] = '.';
                            Row = Row - 1;
                            jagged[Row][Col] = 'P';

                        }
                        else // B
                        {
                            jagged[Row][Col] = '.';
                            Row = Row - 1;
                            jagged[Row][Col] = 'B';
                            gameover = true;

                        }
                    }
                    else
                    {
                        wonTheGame = true;
                        jagged[Row][Col] = '.';
                    }

                }


                if (item == 'D')
                {
                    if (Row + 1 < dimensions[0])
                    {
                        if (jagged[Row + 1][Col] == '.')
                        {
                            jagged[Row][Col] = '.';
                            Row = Row + 1;
                            jagged[Row][Col] = 'P';

                        }
                        else // B
                        {
                            jagged[Row][Col] = '.';
                            Row = Row + 1;
                            jagged[Row][Col] = 'B';
                            gameover = true;

                        }
                    }
                    else
                    {
                        wonTheGame = true;
                        jagged[Row][Col] = '.';
                    }
                }

                if (item == 'L')
                {
                    if (Col - 1 >= 0)
                    {
                        if (jagged[Row][Col - 1] == '.')
                        {
                            jagged[Row][Col] = '.';
                            Col = Col - 1;
                            jagged[Row][Col] = 'P';

                        }
                        else // B
                        {
                            jagged[Row][Col] = '.';
                            Col = Col - 1;
                            jagged[Row][Col] = 'B';
                            gameover = true;

                        }
                    }
                    else
                    {
                        wonTheGame = true;
                        jagged[Row][Col] = '.';
                    }
                }
                if (item == 'R')
                {
                    if (Col + 1 < dimensions[1])
                    {
                        if (jagged[Row][Col + 1] == '.')
                        {
                            jagged[Row][Col] = '.';
                            Col = Col + 1;
                            jagged[Row][Col] = 'P';

                        }
                        else // B
                        {
                            jagged[Row][Col] = '.';
                            Col = Col + 1;
                            jagged[Row][Col] = 'B';
                            gameover = true;

                        }
                    }
                    else
                    {
                        wonTheGame = true;
                        jagged[Row][Col] = '.';
                    }
                }
                for (int row = 0; row < dimensions[0]; row++)
                {
                    for (int col = 0; col < dimensions[1]; col++)
                    {
                        if (jagged[row][col] == 'B')
                        {
                            if (row - 1 >= 0 && jagged[row - 1][col] != 'B' && jagged[row - 1][col] != 'N')
                            {
                                if (jagged[row - 1][col] == 'P')
                                {
                                    gameover = true;
                                    
                                }
                                jagged[row - 1][col] = 'N';
                            }

                            if (row + 1 < dimensions[0] && jagged[row + 1][col] != 'B' && jagged[row + 1][col] != 'N')
                            {
                                if (jagged[row + 1][col] == 'P')
                                {
                                    gameover = true;
                                   
                                }
                                jagged[row + 1][col] = 'N';
                            }

                            if (col + 1 < dimensions[1] && jagged[row][col + 1] != 'B' && jagged[row][col + 1] != 'N')
                            {
                                if (jagged[row][col + 1] == 'P')
                                {
                                    gameover = true;
                                    
                                }
                                jagged[row][col + 1] = 'N';
                            }

                            if (col - 1 >= 0 && jagged[row][col - 1] != 'B' && jagged[row][col - 1] != 'N')
                            {
                                if (jagged[row][col - 1] == 'P')
                                {
                                    gameover = true;
                                    
                                }
                                jagged[row][col - 1] = 'N';
                            }
                        }

                      
                    }
                  
                }
                for (int i = 0; i < dimensions[0]; i++)
                {
                    for (int j = 0; j < dimensions[1]; j++)
                    {
                        if (jagged[i][j] == 'N')
                        {
                            jagged[i][j] = 'B';
                        }
                    }
                }

                if (wonTheGame)
                {
                    break;
                }
                if (gameover)
                {
                    break;
                }
            }

            foreach (var item in jagged)
            {
                Console.WriteLine(string.Join("", item));
            }
            if (wonTheGame)
            {
                Console.WriteLine("won: {0} {1}", Row,Col);
            }
            if (gameover)
            {
                Console.WriteLine("dead: {0} {1}", Row, Col);
            }
        }
    }
}
