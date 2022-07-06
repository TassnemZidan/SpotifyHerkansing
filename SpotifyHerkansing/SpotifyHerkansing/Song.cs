using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyHerkansing
{
    internal enum Genre {
        DRUM_AND_BASS
    }
    internal class Song : iPlayable
    {
        public string Title { get; set; }
        public List<Artist> Artists { get; set; }
        public Genre SongGenre { get; set; }
        public int Length { get; set; }

        public Song(string title) 
        {
            Title = title;
        }

        public Song(string title, List<Artist> artists, Genre songGenre)
        {
            Title = title;
            Artists = artists;
            SongGenre = songGenre;
        }

        override
        public string ToString()
        {
            String ars = "";
            
            foreach (Artist artist in Artists)
            {
                ars = ars + artist.Name + " ";
            }

            return Title + " "+ars+Length;
        }

        public void Play()
        {
            Console.WriteLine("Play: "+ToString());
        }

        public void Pause()
        {
            Console.WriteLine("Pause: " + ToString());
        }

        public void Next()
        {
            Play();
        }

        public void Stop()
        {
            Console.WriteLine("Stop: " + ToString());
        }
    }

}