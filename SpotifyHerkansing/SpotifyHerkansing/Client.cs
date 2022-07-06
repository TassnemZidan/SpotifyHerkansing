using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyHerkansing
{
        internal class Client
    {
        public iPlayable CurrentlyPlaying { get; set; }
        public int CurrentTime { get; set; }
        public bool Playing { get; set; }
        public bool Shuffle { get; set; }
        public bool Repeat { get; set; }
        public List<Person> Persons { get; set; }
        public List<Album> Albums { get; set; }
        public List<Song> Songs { get; set; }

        private Person ActiveUser;
        private Album SelectedAlbum;
        private Song SelectedSong;
        private Person SelectedUser;
        private PlayList SelectedPlaylist;
        private Person SelectedFriend;

        public Client(List<Person> person, List<Album> album, List<Song> song)
        {
            Persons = person;
            Albums = album;
            Songs = song;
        }

        public void SetActiveUser(Person p)
        {
            ActiveUser = p;
        }

        public void ShowAllAlbums()
        {
            foreach(Album album in Albums)
            {
                Console.WriteLine(album);
            }
        }

        public void SelectAlbum(int index)
        {
            if (Albums == null)
            {
                return;
            }

            SelectedAlbum = Albums[index];
            CurrentlyPlaying = SelectedAlbum;
        }

        public void ShowAllSongs()
        {
            foreach (Song song in Songs)
            {
                Console.WriteLine(song);
            }
        }

        public void SelectSong(int index)
        {
            if (Songs == null)
            {
                return;
            }

            SelectedSong = Songs[index];
            CurrentlyPlaying = SelectedSong;
        }

        public void ShowAllUsers()
        {
            foreach (Person person in Persons)
            {
                Console.WriteLine(person);
            }
        }

        public void SelectUser(int index)
        {
            if (Persons == null)
            {
                return;
            }

            SelectedUser = Persons[index];
        }

        public void ShowUserPlaylists()
        {
            foreach (PlayList p in ActiveUser.ShowPlaylists())
            {
                Console.WriteLine(p);
            }
        }

        public void SelectUserPlaylist(int index)
        {
            if (ActiveUser != null && ActiveUser.Playlist != null)
            {
                SelectedPlaylist = ActiveUser.SelectPlaylist(index);
                CurrentlyPlaying = SelectedPlaylist;
            }
        }

        public void NextSong()
        {
            if(CurrentlyPlaying == null)
            {
                return;
            }

            CurrentlyPlaying.Next();
        }

        public void Pause()
        {
            if(CurrentlyPlaying == null)
            {
                return;
            }

            CurrentlyPlaying.Pause();
        }

        public void Play()
        {
            if (CurrentlyPlaying == null)
            {
                return;
            }

            CurrentlyPlaying.Play();
        }

        public void Stop()
        {
            if (CurrentlyPlaying == null)
            {
                return;
            }
            CurrentlyPlaying.Stop();
        }

        public void SetShuffle(bool shuffle)
        {
            Shuffle = shuffle;
        }

        public void SetRepeat(bool repeat)
        {
            Repeat = repeat;
        }

        public void CreatePlaylist(string pl)
        {
            if(ActiveUser == null)
            {
                return;
            }

            PlayList p =ActiveUser.CreatePlaylist(pl);
            SelectedPlaylist = p;
            CurrentlyPlaying = SelectedPlaylist;
        }

        public void ShowPlaylists()
        {
            foreach(PlayList p in ActiveUser.ShowPlaylists())
            {
                Console.WriteLine(p);   
            }
        }   

        public void SelectPlaylist(int index)
        {
            if (ActiveUser != null && ActiveUser.Playlist != null)
            {
                SelectedPlaylist = ActiveUser.SelectPlaylist(index);
                CurrentlyPlaying = SelectedPlaylist;
            }
        }

        public void RemovePlaylist(int index)
        {
            if (ActiveUser != null && ActiveUser.Playlist != null)
            {
                ActiveUser.RemovePlaylist(ActiveUser.Playlist[index]);
            }
        }

          public void ShowSongsInPlaylist()
        {
            foreach(iPlayable p in SelectedPlaylist.ShowPlayable())
            {
                Console.WriteLine(p);
            }
        }
        public void AddToPlaylist(iPlayable p)
        {
            if(SelectPlaylist == null)
            {
                return;
            }

            SelectedPlaylist.Add(p);
        }
     
        public void RemoveFromPlaylist(int i)
        {
            if(SelectPlaylist == null)
            {
                return;
            }

            SelectedPlaylist.Remove(Songs[i]);
        }

        public void ShowFriends()
        {
            foreach (Person p in ActiveUser.ShowFriends())
            {
                Console.WriteLine(p);
            }
        }

        public void SelectFriend(int i)
        {
            if (ActiveUser != null && ActiveUser.Friends != null)
            {
                SelectedFriend = ActiveUser.ShowFriends()[i];
            }
        }

        public void AddFriend(int index)
        {
            if(ActiveUser == null)
            {
                return;
            }

            ActiveUser.AddFriends(Persons[index]);
        }

        public void RemoveFriend(int index)
        {
            if (ActiveUser == null)
            {
                return;
            }

            ActiveUser.RemoveFriend(Persons[index]);
        }
    }
}