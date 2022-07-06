using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyHerkansing
{
   internal class SongCollection : iPlayable
    {
        public string Title { get; set; }
        private List<iPlayable> Playables { get; set; }
        public int Length { get; set; }

        private iPlayable currentlyPlaying;
        private int currentlyPlayingIndex;

        public SongCollection(string title)
        {
            Title = title;
            Playables = new List<iPlayable>();
        }

        public void Add(iPlayable iPlayable)
        {
            Playables.Add(iPlayable);
        }

        public void Remove(iPlayable iPlayable)
        {
            if (Playables.Contains(iPlayable))
            {
                Playables.Remove(iPlayable);
            }
        }

        public List<iPlayable> ShowPlayable()
        {
            return Playables;
        }

        public override string ToString()
        {
            return this.Title;
        }

        public void Play()
        {
            if (currentlyPlaying == null)
            {
                currentlyPlaying = Playables[0];
                currentlyPlayingIndex = 0;
            }
            currentlyPlaying.Play();
        }

        public void Pause()
        {
            if (currentlyPlaying != null)
            {
                currentlyPlaying.Pause();
            }
        }

        public void Next()
        {
            if (currentlyPlaying != null)
            {
                currentlyPlaying = Playables[++currentlyPlayingIndex];
            }
        }

        public void Stop()
        {
            if(currentlyPlaying != null)
            {
                currentlyPlaying.Stop();
            }
        }
    }
}