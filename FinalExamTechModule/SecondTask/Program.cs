using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SecondTask
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                string[] input = Console.ReadLine().Split(':');
                if (input[0] == "end")
                {
                    break;
                }
                var ArtistRegex = Regex.Match(input[0], @"^[A-Z][a-z\s\']+$");

                var SongRegex = Regex.Match(input[1], @"^[A-Z\s]+$");

                if (ArtistRegex.Success && SongRegex.Success)
                {
                    string Artist = ArtistRegex.Value;
                    string Song = SongRegex.Value;

                    string EncryptedArtist = string.Empty;
                    string EncryptedSong = string.Empty;
                    int Key = Artist.Length;

                    for (int i = 0; i < Artist.Length; i++)
                    {
                        char initial = Artist[i];
                        if ((initial >= 65 && initial <= 90) || (initial >= 97 && initial<= 122))
                        {

                        }
                        else
                        {
                            EncryptedArtist += initial;
                            continue;
                        }
                        while (true)
                        {
                           
                            if (Key == 0)
                            {
                                Key = Artist.Length;
                                break;
                                
                            }
                            else if (initial == 'z')
                            {
                                initial = 'a';
                                initial--;
                            }
                            else if (initial == 'Z')
                            {
                                initial = 'A';
                                initial--;
                            }

                            initial++;

                            Key--;
                        }
                        EncryptedArtist += initial;
                    }
                    Key = Artist.Length;
                    for (int i = 0; i < Song.Length; i++)
                    {
                        char initial = Song[i];
                        if ((initial >= 65 && initial <= 90) || (initial >= 97 && initial <= 122))
                        {

                        }
                        else
                        {
                            EncryptedSong += initial;
                            continue;
                        }
                        while (true)
                        {

                            if (Key == 0)
                            {
                                Key = Artist.Length;
                                break;

                            }
                            else if (initial == 'z')
                            {
                                initial = 'a';
                                initial--;
                            }
                            else if (initial == 'Z')
                            {
                                initial = 'A';
                                initial--;
                            }

                            initial++;

                            Key--;
                        }
                        EncryptedSong += initial;
                    }

                    Console.WriteLine("Successful encryption: {0}@{1}", EncryptedArtist, EncryptedSong);

                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }
    }
}
