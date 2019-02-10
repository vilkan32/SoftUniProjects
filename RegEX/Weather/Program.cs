using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Globalization;

namespace WeatherProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, Weather> Weather1 = new Dictionary<string, Weather>();
            while (true)
            {

                string pattern = @"([A-Z]{2})(\d{2}\.\d{1,2})([A-Za-z]+)\|";

                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                var match = Regex.Matches(input, pattern);
                string[] somematch = match.Cast<Match>().Select(a => a.Value).ToArray();
               
                if (match.Count >0)
                {
                    foreach (Match item in match)
                    {
                        Weather TheWeather = new Weather();
                        TheWeather.Town = item.Groups[1].ToString();
                        double result = double.Parse(item.Groups[2].ToString(), NumberStyles.Any, CultureInfo.InvariantCulture);
                        TheWeather.Temperature = result;
                        TheWeather.KindofWeather = item.Groups[3].ToString();
                        if (!Weather1.ContainsKey(item.Groups[1].ToString()))
                        {
                            Weather1.Add(item.Groups[1].ToString(), new Weather());
                            Weather1[item.Groups[1].ToString()] = TheWeather;


                        }
                        else
                        {
                            Weather1[item.Groups[1].ToString()] = TheWeather;
                        }

                    }
                }

            }

            foreach (var item in Weather1.OrderBy(x => x.Value.Temperature))
            {
                Console.WriteLine("{0} => {1:f2} => {2}", item.Value.Town, item.Value.Temperature, item.Value.KindofWeather);
            }


        }
    }
    class Weather
    {
        public  string Town { get; set; }
        public  double Temperature { get; set; }
        public  string KindofWeather {get; set;}
    }

}
