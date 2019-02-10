﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        private const char ArgumentsDelimiter = ' ';
        static void Main(string[] args)
        {
            int sizeOfArray = int.Parse(Console.ReadLine());

            long[] array = Console.ReadLine()
                .Split(ArgumentsDelimiter)
                .Select(long.Parse)
                .ToArray();

            string[] command = new string[3];

            while (!command.Equals("stop"))
            {
                 command = Console.ReadLine().Split(ArgumentsDelimiter).ToArray();
                if (command[0] == "stop")
                {
                    break;
                }
                int[] argsa = new int[2];

                if (command[0].Equals("add") ||
                    command[0].Equals("subtract") ||
                    command[0].Equals("multiply"))
                {
                    string[] stringParams = command.ToArray();
                    argsa[0] = int.Parse(command[1]);
                    argsa[1] = int.Parse(command[2]);

                    PerformAction(array, command[0], argsa);
                    Console.WriteLine();
                }
                else if (command[0].Equals("rshift") || command[0].Equals("lshift"))
                {
                    PerformAction(array, command[0], argsa);
                    Console.WriteLine();
                }
                

                
                

                
            }
        }
        static void PerformAction(long[] arr, string action, int[] args)
        {
            
            int pos = args[0];
            int value = args[1];

            switch (action)
            {
                case "multiply":
                    arr[pos-1] *= value;
                    PrintArray(arr);
                    break;
                case "add":
                    arr[pos-1] += value;
                    PrintArray(arr);
                    break;
                case "subtract":
                    arr[pos-1] -= value;
                    PrintArray(arr);
                    break;
                case "lshift":
                    ArrayShiftLeft(arr);
                    break;
                case "rshift":
                    ArrayShiftRight(arr);
                    break;
            }
            
        }

        private static void ArrayShiftRight(long[] array)
        {
            long num = array[array.Length - 1];
            for (int i = array.Length - 1; i >= 1; i--)
            {
                array[i] = array[i - 1];

            }
            array[0] = num;

            PrintArray(array);
        }

        private static void ArrayShiftLeft(long[] array)
        {
            long num = array[0];

            for (int i = 0; i < array.Length - 1; i++)
            {

                array[i] = array[i + 1];

            }
            array[array.Length - 1] = num;
            PrintArray(array);
        }

        private static void PrintArray(long[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

    }
}

