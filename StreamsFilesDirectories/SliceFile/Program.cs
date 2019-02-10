using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SliceFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string destinationDirectory = @"C:\Users\Acer\Desktop\Lab-Streams\04. CSharp-Advanced-Streams-Files-and-Directories-Lab-Resources\Resources\05. Slice File\";

            string sourceFile = @"C:\Users\Acer\Desktop\Lab-Streams\04. CSharp-Advanced-Streams-Files-and-Directories-Lab-Resources\Resources\05. Slice File\sliceMe.mp4";

            int parts = 4;

            List<string> files = new List<string>() { "Part-1.mp4", "Part-2.mp4 ", "Part-3.mp4 ", "Part-4.mp4" };

            using (var streamReadFile = new FileStream(sourceFile, FileMode.Open))
            {
                long pieceSize = (long)Math.Ceiling((double)streamReadFile.Length / parts);
                for (int i = 0; i < parts; i++)
                {
                    long currentPieceSize = 0;
                    using (var streamCreateFile = new FileStream(destinationDirectory + files[i], FileMode.Create))
                    {

                        byte[] buffer = new byte[4096];

                        while ((streamReadFile.Read(buffer, 0,
                        buffer.Length)) == buffer.Length)
                        {

                            currentPieceSize += buffer.Length;
                            streamCreateFile.Write(buffer, 0,
                            buffer.Length);

                            if (currentPieceSize >= pieceSize)
                                break;
                        }
                    }
                }
            }
        }
    }
}
