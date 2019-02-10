using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            long JarvisPower = long.Parse(Console.ReadLine());
            Arms FirstArm = new Arms();
            Arms SecondArm = new Arms();
            Legs FirstLeg = new Legs();
            Legs SecondLeg = new Legs();
            Torso Torse = new Torso();
            Head Head = new Head();
            
            while (true)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                if (input[0] == "Assemble!")
                {
                    break;
                }
                if (input[0] == "Head")
                {
                    if (Head.Energy == 0)
                    {
                        Head.Energy = Convert.ToInt32(input[1]);
                        Head.IQ = Convert.ToInt32(input[2]);
                        Head.SkinMaterial = input[3];
                    }
                    else if (Head.Energy > Convert.ToInt32(input[1]))
                    {
                        Head.Energy = Convert.ToInt32(input[1]);
                        Head.IQ = Convert.ToInt32(input[2]);
                        Head.SkinMaterial = input[3];
                    }
                }
                else if (input[0] == "Torso")
                {
                    if (Torse.Energy == 0)
                    {

                        Torse.Energy = Convert.ToInt32(input[1]);
                        Torse.CPUsize = Convert.ToDouble(input[2]);
                        Torse.HousingMaterial = input[3];
                    }
                    else if (Torse.Energy > Convert.ToInt32(input[1]))
                    {
                        Torse.Energy = Convert.ToInt32(input[1]);
                        Torse.CPUsize = Convert.ToDouble(input[2]);
                        Torse.HousingMaterial = input[3];
                    }
                }
                else if (input[0] == "Arm")
                {
                    if (FirstArm.Energy == 0)
                    {
                        FirstArm.Energy  = Convert.ToInt32(input[1]);
                        FirstArm.Reach = Convert.ToInt32(input[2]);
                        FirstArm.CountFIngers = Convert.ToInt32(input[3]);
                    }
                    else if (FirstArm.Energy != 0 && SecondArm.Energy == 0)
                    {
                        SecondArm.Energy = Convert.ToInt32(input[1]);
                        SecondArm.Reach = Convert.ToInt32(input[2]);
                        SecondArm.CountFIngers = Convert.ToInt32(input[3]);
                    }
                    else if (FirstArm.Energy != 0 && SecondArm.Energy != 0)
                    {
                        if (FirstArm.Energy > Convert.ToInt32(input[1]))
                        {
                            FirstArm.Energy = Convert.ToInt32(input[1]);
                            FirstArm.Reach = Convert.ToInt32(input[2]);
                            FirstArm.CountFIngers = Convert.ToInt32(input[3]);
                        }
                        else if (SecondArm.Energy > Convert.ToInt32(input[1]))
                        {
                            SecondArm.Energy = Convert.ToInt32(input[1]);
                            SecondArm.Reach = Convert.ToInt32(input[2]);
                            SecondArm.CountFIngers = Convert.ToInt32(input[3]);
                        }
                    }
                }
                else if (input[0] == "Leg")
                {
                    if (FirstLeg.Energy == 0)
                    {
                        FirstLeg.Energy = Convert.ToInt32(input[1]);
                        FirstLeg.Strength = Convert.ToInt32(input[2]);
                        FirstLeg.Speed = Convert.ToInt32(input[3]);
                    }
                    else if (FirstLeg.Energy != 0 && SecondLeg.Energy == 0)
                    {
                        SecondLeg.Energy = Convert.ToInt32(input[1]);
                        SecondLeg.Strength = Convert.ToInt32(input[2]);
                        SecondLeg.Speed = Convert.ToInt32(input[3]);
                    }
                    else if (FirstLeg.Energy != 0 && SecondLeg.Energy != 0)
                    {
                        if (FirstLeg.Energy > Convert.ToInt32(input[1]))
                        {
                            FirstLeg.Energy = Convert.ToInt32(input[1]);
                            FirstLeg.Strength = Convert.ToInt32(input[2]);
                            FirstLeg.Speed = Convert.ToInt32(input[3]);
                        }
                        else if (SecondLeg.Energy > Convert.ToInt32(input[1]))
                        {
                            SecondLeg.Energy = Convert.ToInt32(input[1]);
                            SecondLeg.Strength = Convert.ToInt32(input[2]);
                            SecondLeg.Speed = Convert.ToInt32(input[3]);
                        }
                    }
                }

            }



            List<Arms> Arms = new List<Arms>();
            List<Legs> Legs = new List<Legs>();
            Arms.Add(FirstArm);
            Arms.Add(SecondArm);
            Legs.Add(FirstLeg);
            Legs.Add(SecondLeg);
            bool cango = true;
            if (FirstArm.Energy != 0 && SecondLeg.Energy != 0 && SecondArm.Energy != 0 && FirstLeg.Energy != 0 && Head.Energy != 0 && Torse.Energy != 0)
            {

            }
            else
            {
                cango = false;
                Console.WriteLine("We need more parts!");
            }
            List<long> Sum = new List<long>();

            Sum.Add(FirstArm.Energy);
            Sum.Add(SecondLeg.Energy);
            Sum.Add(SecondArm.Energy);
            Sum.Add(FirstLeg.Energy);
            Sum.Add(Head.Energy);
            Sum.Add(Torse.Energy);

            long TheSUm = Sum.Sum();
            if (TheSUm > JarvisPower)
            {
                cango = false;
                Console.WriteLine("We need more power!");
            }


            if (cango)
            {
                Console.WriteLine("Jarvis:");
                Console.WriteLine("#Head:");
                Console.WriteLine("###Energy consumption: {0}", Head.Energy);
                Console.WriteLine("###IQ: {0}",Head.IQ);
                Console.WriteLine("###Skin material: {0}", Head.SkinMaterial);
                Console.WriteLine("#Torso:");
                Console.WriteLine("###Energy consumption: {0}", Torse.Energy);
                Console.WriteLine("###Processor size: {0:f1}", Torse.CPUsize);
                Console.WriteLine("###Corpus material: {0}", Torse.HousingMaterial);
                foreach (var item in Arms.OrderBy(x => x.Energy))
                {
                    /*
                     * #Arm:
                    ###Energy consumption: 100
                   ###Reach: 30
                          ###Fingers: 4
                    */

                    Console.WriteLine("#Arm:");
                    Console.WriteLine("###Energy consumption: {0}", item.Energy);
                    Console.WriteLine("###Reach: {0}", item.Reach);
                    Console.WriteLine("###Fingers: {0}", item.CountFIngers);
                }
                foreach (var item in Legs.OrderBy(x => x.Energy))
                {
                  

                    Console.WriteLine("#Leg:");
                    Console.WriteLine("###Energy consumption: {0}", item.Energy);
                    Console.WriteLine("###Strength: {0}", item.Strength);
                    Console.WriteLine("###Speed: {0}", item.Speed);
                }
            }


        }
    }

    class Arms
    {
        public int Energy { get; set; }
        public int Reach { get; set; }
        public int CountFIngers { get; set; }
    }

    class Legs
    {
        public int Energy { get; set; }
        public int Strength { get; set; }
        public int Speed { get; set; }
    }
    class Torso
    {
        public int Energy { get; set; }
        public double CPUsize { get; set; }
        public string HousingMaterial { get; set; }

    }
    class Head
    {
        public int Energy { get; set; }
        public int IQ { get; set; }
        public string SkinMaterial { get; set; }
    }
  
    
}
