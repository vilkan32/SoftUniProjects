using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> InputList = Console.ReadLine().Split(new char[] { ','}, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> LessonsWithExercises = new List<string>();
            for (int i = 0; i < InputList.Count(); i++)
            {
                InputList[i] = InputList[i].TrimEnd().TrimStart();
            }

            while (true)
            {
                List<string> Commands = Console.ReadLine().Split(':').ToList();
                if (Commands[0] == "course start")
                {
                    break;
                }
                if (Commands[0] == "Add")
                {
                    if (!InputList.Contains(Commands[1]))
                    {
                        InputList.Add(Commands[1]);
                    }
                }
                else if (Commands[0] == "Insert")
                {
                    if (!InputList.Contains(Commands[1]))
                    {
                        InputList.Insert(Convert.ToInt32(Commands[2]), Commands[1]);
                    }
                }
                else if (Commands[0] == "Remove")
                {
                    if (InputList.Contains(Commands[1]))
                    {
                        InputList.Remove(Commands[1]);
                    }
                }
                else if (Commands[0] == "Swap")
                {
                    if (InputList.Contains(Commands[1]) && InputList.Contains(Commands[2]))
                    {
                        int indexofthefirst = InputList.IndexOf(Commands[1]);
                        int indexofthesecond = InputList.IndexOf(Commands[2]);

                        InputList[indexofthefirst] = Commands[2];
                        InputList[indexofthesecond] = Commands[1];

                    }
                }
                else if (Commands[0] == "Exercise")
                {
                    if (InputList.Contains(Commands[1]) && !LessonsWithExercises.Contains(Commands[1]))
                    {
                        LessonsWithExercises.Add(Commands[1]);
                    }
                    else if (!InputList.Contains(Commands[1]))
                    {
                        InputList.Add(Commands[1]);
                        LessonsWithExercises.Add(Commands[1]);
                    }
                }

            }
            int indexer = 1;
            for (int i = 0; i < InputList.Count(); i++)
            {
                Console.WriteLine(indexer + "." + InputList[i]);
                if (LessonsWithExercises.Contains(InputList[i]))
                {
                    indexer++;
                    Console.WriteLine(indexer + "." + InputList[i] + "-Exercise");
                    
                }
                indexer++;
            }

        }
    }
}
