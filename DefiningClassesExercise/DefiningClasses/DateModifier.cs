using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class DateModifier
    {

        public static double GetDifference(string dateOne, string dateTwo)
        {
            int[] firstDate = dateOne.Split(' ').Select(int.Parse).ToArray();
            int[] secondDate = dateTwo.Split(' ').Select(int.Parse).ToArray();
            var date = new DateTime(firstDate[0], firstDate[1], firstDate[2]);
            var nextDate = new DateTime(secondDate[0], secondDate[1], secondDate[2]);

            return Math.Abs((date - nextDate).TotalDays);


        }

    }
}
