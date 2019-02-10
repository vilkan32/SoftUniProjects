using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, Dictionary<string, long>> CountryList = new Dictionary<string, Dictionary<string, long>>();
            Dictionary<string, long> CountryPopulation = new Dictionary<string, long>();

            while (true)
            {
                string input = Console.ReadLine();
                List<string> InputToList = input.Split('|').ToList();
                if (input == "report")
                break;

                string Country = InputToList[1];
                string City = InputToList[0];
                long Population = Convert.ToInt64(InputToList[2]);               

                if (!CountryList.ContainsKey(Country))
                {
                    CountryList.Add(Country, new Dictionary<string,long>());
                }
               

                if (!CountryList[Country].ContainsKey(City))
                {
                    CountryList[Country].Add(City,Population);
                }
               

                if (!CountryPopulation.ContainsKey(Country))
                {
                    CountryPopulation.Add(Country, 0);
                }
                CountryPopulation[Country] += Population;

            }
            
          
           List<long> orderedList = new List<long>();
            foreach (var item in CountryPopulation)
            {
                orderedList.Add(item.Value);          
            }
            orderedList.Sort();
            Dictionary<string, long> CountryPopulationrenew = new Dictionary<string, long>();
            
                for (int i = orderedList.Count - 1; i >= 0; i--)
                {
                    foreach (var Key in CountryPopulation.Keys)
                    {
                        if (CountryPopulation[Key] == orderedList[i])
                        {
                        try
                        {
                            CountryPopulationrenew.Add(Key, orderedList[i]);
                        }
                        catch (Exception)
                        {

                            continue;
                        }
                        break;
                        }

                    }

                }

            Dictionary<string, Dictionary<string, long>> CountryListrenew = new Dictionary<string, Dictionary<string, long>>();
            foreach (var item in CountryList)
            {
                orderedList = new List<long>();
                foreach (var value in item.Value)
                {
                    orderedList.Add(value.Value);
                }
                orderedList.Sort();
                if (!CountryListrenew.ContainsKey(item.Key))
                {
                    CountryListrenew.Add(item.Key, new Dictionary<string, long>());

                }
               
                    for (int i = orderedList.Count - 1; i >= 0; i--)
                    {
                    foreach (var newvalue in item.Value)
                    {
                        if (newvalue.Value == orderedList[i])
                        {
                            try
                            {
                                CountryListrenew[item.Key].Add(newvalue.Key, newvalue.Value);
                            }
                            catch (Exception)
                            {

                                continue;
                            }
                            break;
                        }
                    }
                    }
                

            }

            foreach (var item in CountryPopulationrenew)
            {
                Console.WriteLine("{0} (total population: {1})", item.Key,item.Value);

                foreach (var newitem in CountryListrenew[item.Key])
                {
                    Console.WriteLine("=>{0}: {1}",newitem.Key,newitem.Value);
                }
            }
           
        }
    }
}
