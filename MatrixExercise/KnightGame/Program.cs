using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int dimensions = int.Parse(Console.ReadLine());

            char[][] jagged = new char[dimensions][];

            for (int row1 = 0; row1 < jagged.Length; row1++)
            {
                jagged[row1] = new char[dimensions];
                string input = Console.ReadLine();
                for (int col = 0; col < dimensions; col++)
                {
                    jagged[row1][col] = input[col];
                }
            }
            int countTimesKdestroyed = 0;
            int Row = -1;
            int Col = -1;
            int counter = 0;
            int row = 0;
            while (true)
            {
               
                    for (int col = 0; col < jagged[row].Length; col++)
                    {
                        int current = 0;
                        if (jagged[row][col] == 'K')
                        {

                            if(row + 2 < dimensions && col + 1 < dimensions)
                            {
                                if (jagged[row + 2][col + 1] == 'K')
                                {
                                    current++;

                                }
                            }
                            

                            if(row + 2 < dimensions && col - 1 >= 0)
                            {
                                if (jagged[row + 2][col - 1] == 'K')
                                {
                                    current++;
                                }
                            }
                            
                            if(row - 2 >= 0 && col + 1 < dimensions)
                            {
                                if (jagged[row - 2][col + 1] == 'K')
                                {
                                    current++;
                                }
                            }
                            
                            if( row - 2 >= 0 && col - 1 >= 0)
                            {
                                if (jagged[row - 2][col - 1] == 'K')
                                {
                                    current++;
                                }
                            }
                           
                            if(row + 1 < dimensions && col + 2 < dimensions)
                            {
                                if (jagged[row + 1][col+2] == 'K')
                                {
                                    current++;
                                }
                            }
                            
                            if(row + 1 < dimensions && col - 2 >= 0)
                            {
                                if (jagged[row + 1][col - 2] == 'K')
                                {
                                    current++;
                                }
                            }
                            
                            if(row - 1 >=0 && col + 2 < dimensions)
                            {
                                if (jagged[row - 1][col + 2] == 'K')
                                {
                                    current++;
                                }
                            }
                            
                            if(row - 1 >= 0 && col - 2 >= 0)
                            {
                                if (jagged[row - 1][col - 2] == 'K')
                                {
                                    current++;
                                }
                            }
                            

                        }

                        if (countTimesKdestroyed < current)
                        {
                            countTimesKdestroyed = current;
                            Row = row;
                            Col = col;
                        }
                    
                }

                if (row < dimensions)
                {
                    if (row == dimensions - 1)
                    {
                                               
                        if (countTimesKdestroyed == 0)
                        {
                            break;
                        }
                        jagged[Row][Col] = '0';
                        row = 0;
                        counter++;
                        countTimesKdestroyed = 0;
                    }
                    else
                    {
                        row++;
                    }
                }
               



              
            }
            Console.WriteLine(counter);
        }
    }
}
