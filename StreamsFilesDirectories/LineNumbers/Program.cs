using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = new StreamReader(@"C:\Users\Acer\Desktop\Lab-Streams\04. CSharp-Advanced-Streams-Files-and-Directories-Lab-Resources\Resources\02. Line Numbers\Input.txt");

            using (reader)
            {
                int counter = 1;
                string line = reader.ReadLine();

                using (var writer = new StreamWriter(@"C:\Users\Acer\Desktop\Lab-Streams\04. CSharp-Advanced-Streams-Files-and-Directories-Lab-Resources\Resources\02. Line Numbers\Output.txt"))
                {
                    while (line!= null)
                    {
                        writer.WriteLine("{0}.  {1}", counter, line);
                        counter++;
                        line = reader.ReadLine();
                    }
                    
                }

            }




        }
    }
}
