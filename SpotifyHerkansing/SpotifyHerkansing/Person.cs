using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyHerkansing
{
   internal class Person
    {

        public string Name { get; set; }
        public List<PlayList> Playlist { get; set; }
        public List<Person> Friends { get; set; }

        public Person(string name)
        {
            Name = name;
            Friends = new List<Person>();
            Playlist = new List<PlayList>();
        }

        public List<Person> ShowFriends()
        {
            return Friends;
        }

        public void AddFriends(Person person)
        {
            Friends.Add(person);
        }

        public void RemoveFriend(Person person)
        {
            if (Friends.Contains(person))
            {
                Friends.Remove(person);
            }
        }

        public List<PlayList> ShowPlaylists() 
        { 
            return Playlist; 
        }

        public PlayList SelectPlaylist(int index)
        {
            return Playlist[index];
        }

        public PlayList CreatePlaylist(String str)
        {
            PlayList pl = new PlayList(this, str);
            Playlist.Add(pl);
            return pl;
        }

        public void RemovePlaylist(PlayList playList)
        {
            Playlist.Remove(playList);
        }

        public void AddToPlayList(iPlayable iplayable)
        {
            foreach (PlayList playlist in Playlist)
            {
                playlist.Add(iplayable);
            }
        }

        public void RemoveFromPlayList(iPlayable iPlayable)
        {
            foreach (PlayList playlist in Playlist)
            {
                playlist.Remove(iPlayable);
            }
        }

        public override string ToString()
        {
            return "";
        }
    }
}
    

