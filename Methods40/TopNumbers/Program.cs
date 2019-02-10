using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string currentnumber = i.ToString();
                int sumofdigits = 0;
                bool odd = false;
                bool candividebyeight = false;
                foreach (var item in currentnumber)
                {
                    sumofdigits += Convert.ToInt32(item.ToString());
                    if (Convert.ToInt32(item.ToString()) % 2 != 0)
                    {
                        odd = true;
                    }
                }
                if (sumofdigits % 8 == 0)
                {
                    candividebyeight = true;
                }
                if (odd && candividebyeight)
                {
                    Console.WriteLine(currentnumber);
                }
            }
        }
    }
}
