using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DirectoryTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string path = Console.ReadLine();
            var files = Directory.GetFiles(path);
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            Dictionary<string, List<FileInfo>> extensionNames = new Dictionary<string, List<FileInfo>>();

            foreach (var item in files)
            {
                var info = new FileInfo(item);
                if (!extensionNames.ContainsKey(info.Extension))
                {
                    extensionNames.Add(info.Extension, new List<FileInfo>());
                    extensionNames[info.Extension].Add(info);
                }
                else
                {
                    extensionNames[info.Extension].Add(info);
                }
                
            }

            using (var writer = new StreamWriter(desktopPath + "/report.txt"))
            {
                foreach (var kvp in extensionNames.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
                {
                    writer.WriteLine(kvp.Key);
                    foreach (var set in kvp.Value.OrderBy(x => x.Length))
                    {
                        writer.WriteLine($"--{set.Name} - {(double)set.Length / 1024:f3}kb");
                    }
                }
            }
           
        }
    }
}
