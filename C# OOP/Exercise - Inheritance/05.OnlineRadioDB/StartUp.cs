using _05.OnlineRadioDB.Exceptions;

namespace _05.OnlineRadioDB
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            var songs = new List<Song>();
            int durationOfPlaylist = 0;

            for (int i = 0; i < lines; i++)
            {
                string[] songDetails = Console.ReadLine().Split(new []{';'}, StringSplitOptions.RemoveEmptyEntries);

                string artistName = songDetails[0];
                string songName = songDetails[1];
                string[] lengthDetails = songDetails[2].Split(new[] { ':' }, StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    int minutes = int.Parse(lengthDetails[0]);
                    int seconds = int.Parse(lengthDetails[1]);
                    var song = new Song(artistName, songName, minutes, seconds);
                    songs.Add(song);
                    durationOfPlaylist += seconds + minutes*60;
                    Console.WriteLine("Song added.");
                }
                catch (InvalidSongException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException fex)
                {
                    Console.WriteLine("Invalid song length.");
                }
            }
            Console.WriteLine($"Songs added: {songs.Count}");
            int hoursPl = (int)(durationOfPlaylist / 3600);
            int minutesPl = ((int)(durationOfPlaylist / 60)) % 60;
            int secondsPl = durationOfPlaylist % 60;
            Console.WriteLine($"Playlist length: {hoursPl}h {minutesPl}m {secondsPl}s");
        }
    }
}
