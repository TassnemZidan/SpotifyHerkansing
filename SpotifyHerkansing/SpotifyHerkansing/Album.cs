using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyHerkansing
{
    internal class Album  : SongCollection
    {
        public List<Artist> Artists { get; set; }
        public Album(List<Artist> artists, string title, List<Song> songs) : base(title)
        {
            Artists = artists;
                
            for (int i = 0; i < songs.Count; i++)
            {
                base.Add(songs[i]);
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
   
   
