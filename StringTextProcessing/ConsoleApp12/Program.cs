using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Input = Console.ReadLine().Split(new char[] {' ',}, StringSplitOptions.RemoveEmptyEntries).ToList();
            decimal result = 0;
            for (int i = 0; i < Input.Count(); i++)
            {
                string item = Input[i];
                List<char> Item = item.ToList();
                IEnumerable<int> Numbers1 = Enumerable.Range(65, 90);
                IEnumerable<int> Numbers2 = Enumerable.Range(97, 122);
                char first = 'a';
                char second = 'a';
                if (!Numbers1.Contains(Item[1]) && !Numbers1.Contains(Item[Item.Count() - 2]))
                {
                     first = item[0];
                     second = item[Item.Count() - 1];
                }
                else
                {
                    first = item[1];
                    second = item[Item.Count() - 2];
                }
                
               
              
                if (!Numbers1.Contains(first) && !Numbers2.Contains(first))
                {
                    

                    
                    Item.Remove(second);
                    string number = string.Empty;
                    for (int x = 0; x < Item.Count(); x++)
                    {
                        number += Item[x].ToString();
                    }
                    decimal Number = Convert.ToDecimal(number);
                    decimal sum = 0;
                    if (first >= 65 && first <= 90)
                    {
                        sum = Number / (first - 64);
                    }
                    else if (first >= 97 && first <= 122)
                    {
                        sum = Number * (first - 96);
                    }
                    else
                    {
                        sum = Number;
                    }

                    if (second >= 65 && second <= 90)
                    {
                        sum -= second - 64;
                    }
                    else if (second >= 97 && second <= 122)
                    {
                        sum += second - 96;
                    }

                    result += sum;

                }
                else if(!Numbers1.Contains(second) && !Numbers2.Contains(second))
                {
                    

                    Item.Remove(first);
                   
                    string number = string.Empty;
                    for (int x = 0; x < Item.Count(); x++)
                    {
                        number += Item[x].ToString();
                    }
                    decimal Number = Convert.ToDecimal(number);
                    decimal sum = 0;
                    if (first >= 65 && first <= 90)
                    {
                        sum = Number / (first - 64);
                    }
                    else if (first >= 97 && first <= 122)
                    {
                        sum = Number * (first - 96);
                    }
                    else
                    {
                        sum = Number;
                    }

                    if (second >= 65 && second <= 90)
                    {
                        sum -= second - 64;
                    }
                    else if (second >= 97 && second <= 122)
                    {
                        sum += second - 96;
                    }

                    result += sum;
                }
                else
                {
                    Item.Remove(first);
                    Item.Remove(second);
                    string number = string.Empty;
                    for (int x = 0; x < Item.Count(); x++)
                    {
                        number += Item[x].ToString();
                    }
                    decimal Number = Convert.ToDecimal(number);
                    decimal sum = 0;
                    if (first >= 65 && first <= 90)
                    {
                        sum = Number / (first - 64);
                    }
                    else if (first >= 97 && first <= 122)
                    {
                        sum = Number * (first - 96);
                    }
                    else
                    {
                        sum = Number;
                    }

                    if (second >= 65 && second <= 90)
                    {
                        sum -= second - 64;
                    }
                    else if (second >= 97 && second <= 122)
                    {
                        sum += second - 96;
                    }

                    result += sum;
                }
                
            }

            
            Console.WriteLine("{0:f2}", result);



        }
    }
}
