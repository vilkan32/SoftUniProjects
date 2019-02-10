using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MergeFiles
{
    class Program
    {
        static void Main(string[] args)
        {

            var readOne = new StreamReader(@"C:\Users\Acer\Desktop\Lab-Streams\04. CSharp-Advanced-Streams-Files-and-Directories-Lab-Resources\Resources\04. Merge Files\FileOne.txt");
            var writer = new StreamWriter(@"C:\Users\Acer\Desktop\Lab-Streams\04. CSharp-Advanced-Streams-Files-and-Directories-Lab-Resources\Resources\04. Merge Files\Output.txt");

            using (readOne)
            {
                string line = readOne.ReadLine();
                using (var readTwo = new StreamReader(@"C:\Users\Acer\Desktop\Lab-Streams\04. CSharp-Advanced-Streams-Files-and-Directories-Lab-Resources\Resources\04. Merge Files\FileTwo.txt"))
                {
                    using (writer)
                    {
                        string linetwo = readTwo.ReadLine();
                        while (line != null && linetwo != null)
                        {
                            writer.WriteLine(line);                            
                            writer.WriteLine(linetwo);
                            linetwo = readTwo.ReadLine();
                            line = readOne.ReadLine();
                        }
                    }
                }
                    


            }

        }
    }
}
