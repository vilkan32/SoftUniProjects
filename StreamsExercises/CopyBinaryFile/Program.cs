using System;
using System.IO;

namespace CopyBinaryFile
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new FileStream("../../../copyMe.png", FileMode.Open))
            {

                using (var writer = new FileStream("../../../resultCopy.png", FileMode.Create)) // faila se kopira v sushtata direktoriq na programata s razlichno ime 
                {
                    byte[] buffer = new byte[4096];

                    while (true)
                    {
                        var total = reader.Read(buffer, 0, buffer.Length);

                        if (total == 0)
                        {
                            break;
                        }

                        writer.Write(buffer, 0, buffer.Length);
                    }

                }


            }
        }
    }
}
