﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {

            var startDate = DateTime.Parse(Console.ReadLine());
            var endDate = DateTime.Parse(Console.ReadLine());
            var holidaysCount = 0;
            for (var date = startDate; date <= endDate; date.AddDays(1))
            {
                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                    holidaysCount++;
            }
            Console.WriteLine(holidaysCount);

        }
    }
}
