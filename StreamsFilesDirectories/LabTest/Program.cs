using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTest
{
    class Program
    {
        static void Main(string[] args)
        {


            using (var reader = new StreamReader(@"C:\Users\Acer\Desktop\Lab-Streams\04. CSharp-Advanced-Streams-Files-and-Directories-Lab-Resources\Resources\01. Odd Lines\Input.txt"))
            {
                char[] buffer = new char[32];

                while (true)
                {
                    var total = reader.Read(buffer, 0, buffer.Length);


                   
                }
            }



        }
    }
}
