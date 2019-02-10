using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MeTubeStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<VideoStatistics> VideoInformation = new List<VideoStatistics>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "stats time")
                {
                    break;
                }
                var AdditionalMovie = Regex.Match(input, @"(.+)-(\d+)");

                if (AdditionalMovie.Success)
                {
                    bool itExists = false;
                    for (int i = 0; i < VideoInformation.Count(); i++)
                    {
                        if (VideoInformation[i].VideoName == AdditionalMovie.Groups[1].Value)
                        {
                            VideoInformation[i].Views += int.Parse(AdditionalMovie.Groups[2].Value);
                            itExists = true;
                        }

                    }

                    if (!itExists)
                    {
                        VideoStatistics localVariable = new VideoStatistics();

                        localVariable.VideoName = AdditionalMovie.Groups[1].Value;
                        localVariable.Views = int.Parse(AdditionalMovie.Groups[2].Value);
                        VideoInformation.Add(localVariable);

                    }

                    continue;
                }

                var Like = Regex.Match(input, @"^like:(.*)");

                if (Like.Success)
                {
                    for (int i = 0; i < VideoInformation.Count(); i++)
                    {
                        if (VideoInformation[i].VideoName == Like.Groups[1].Value)
                        {
                            VideoInformation[i].Likes += 1;
                           
                        }

                    }

                    continue;
                }

                var Dislike = Regex.Match(input, @"dislike:(.*)");
                if (Dislike.Success)
                {
                    for (int i = 0; i < VideoInformation.Count(); i++)
                    {
                        if (VideoInformation[i].VideoName == Dislike.Groups[1].Value)
                        {
                            VideoInformation[i].Likes -= 1;

                        }

                    }
                    continue;
                }



            }
            string orderThem = Console.ReadLine();

            if (orderThem == "by views")
            {
                foreach (var item in VideoInformation.OrderByDescending(x => x.Views))
                {
                
                    Console.WriteLine(item.VideoName + " - " + item.Views + " views - "+ item.Likes + " likes");
                }
            }
            else if (orderThem == "by likes")
            {
                foreach (var item in VideoInformation.OrderByDescending(x => x.Likes))
                {

                    Console.WriteLine(item.VideoName + " - " + item.Views + " views - " + item.Likes + " likes");
                }
            }
        }
    }

    class VideoStatistics
    {
       public string VideoName { get; set; }
       public int Views { get; set; }
       public int Likes { get; set; }

    }
}
