using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderSize
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] filesInDir = Directory.GetFiles(@"C:\Users\Acer\Desktop\Lab-Streams\04. CSharp-Advanced-Streams-Files-and-Directories-Lab-Resources\Resources\06. Folder Size\TestFolder");
            double sum = 0;
            foreach (var item in filesInDir)
            {
                var info = new FileInfo(item);

                sum += info.Length;
            }

            Console.WriteLine(sum / 1024 / 1024);
        }
    }
}
