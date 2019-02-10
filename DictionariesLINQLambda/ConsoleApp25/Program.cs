using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            Dictionary<string, string> UserLicencePlate = new Dictionary<string, string>();
            for (int i = 1; i <= a; i++)
            {
                string readline = Console.ReadLine();
               
                List<string> SplitLine = readline.Split(' ').ToList();

                string command = SplitLine[0];
                string username = SplitLine[1];
                string licenceplate = "";
                if (command != "unregister")
                {
                     licenceplate = SplitLine[2];
                }
                if (licenceplate.Length > 8)
                {
                    Console.WriteLine("ERROR: invalid license plate {0}",licenceplate);
                    continue;
                }
                if (UserLicencePlate.ContainsValue(licenceplate) && command == "register")
                {
                    Console.WriteLine("ERROR: license plate {0} is busy", licenceplate);
                    continue;
                }
                if (UserLicencePlate.ContainsKey(username) && command == "register")
                {
                    Console.WriteLine("ERROR: already registered with plate number {0}", UserLicencePlate[username]);
                    continue;
                }
                if (UserLicencePlate.ContainsKey(username) && command == "unregister")
                {
                    Console.WriteLine("user {0} unregistered successfully", username);
                    UserLicencePlate.Remove(username);
                    continue;
                }
                else if(!UserLicencePlate.ContainsKey(username) && command == "unregister")
                {
                    Console.WriteLine("ERROR: user {0} not found", username);
                    continue;

                }

                // 65 - 90
                List<char> Licenceplate = licenceplate.ToList();
                    bool firstchar = false;
                    bool secondchar = false;
                    bool thirdchar = false;
                    bool fourthchar = false;
                    bool fifth = false;
                    bool sixth = false;
                    bool seventh = false;
                    bool eight = false;
                    if (Licenceplate[0] >= 65 && Licenceplate[0] <= 90)
                    {
                        firstchar = true;
                    }
                    if (Licenceplate[1] >= 65 && Licenceplate[1] <= 90)
                    {
                        secondchar = true;
                    }
                Licenceplate.Reverse();
                    if (Licenceplate[0] >= 65 && Licenceplate[0] <= 90)
                    {
                        thirdchar = true;
                    }
                     if (Licenceplate[1] >= 65 && Licenceplate[1] <= 90)
                    {
                        fourthchar = true;
                    }
                Licenceplate.Reverse();
                    // 48 - 57
                    if (Licenceplate[2] >= 48 && Licenceplate[2] <= 57)
                    {

                        fifth = true;
                    }
                     if (Licenceplate[3] >= 48 && Licenceplate[3] <= 57)
                    {
                        sixth = true;
                    }
                     if (Licenceplate[4] >= 48 && Licenceplate[4] <= 57)
                    {
                        seventh = true;
                    }
                     if (Licenceplate[5] >= 48 && Licenceplate[5] <= 57)
                    {
                        eight = true;
                    }
                   


                    if (firstchar && secondchar && thirdchar && fourthchar && fifth && sixth && eight && seventh)
                    {
                        if (!UserLicencePlate.ContainsKey(username) && command== "register" && !UserLicencePlate.ContainsValue(licenceplate))
                        {
                            UserLicencePlate.Add(username, licenceplate);
                            Console.WriteLine("{0} registered {1} successfully",username,licenceplate);
                        continue;
                        }
                     
                     

                    }
                    else
                    {
                        Console.WriteLine("ERROR: invalid license plate {0}", licenceplate);
                    continue;
                    }

            }


            

            foreach (var item in UserLicencePlate)
            {
                Console.WriteLine("{0} => {1}",item.Key,item.Value);
            }


        }
    }
}
