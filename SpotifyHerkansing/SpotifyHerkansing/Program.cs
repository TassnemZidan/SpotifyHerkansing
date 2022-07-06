using System;
using SpotifyHerkansing;
public class MyClass
{
    public static void Main()
    {
        Artist artist = new Artist("NCT", new List<Album>());

        List<Artist> artists = new List<Artist>();
        artists.Add(artist);

        Song song1 = new Song("Afterlife", artists, Genre.DRUM_AND_BASS);
        Song song2 = new Song("Dancing In The Rain", artists, Genre.DRUM_AND_BASS);
        Song song3 = new Song("Say To Me", artists, Genre.DRUM_AND_BASS);

        Album album = new Album(new List<Artist>() {artist}, "Astrophysical", new List<Song>() { song1, song2 });
        artist.AddAlbum(album);

        Person p = new Person("John");
        Person p1 = new Person("Robert");

        p.AddFriends(p1);

        Client client = new Client(new List<Person>() { p, p1 }, new List<Album>() { album }, new List<Song>() { song1, song2, song3 });

        client.SetActiveUser(p1);
        client.AddFriend(0);
        client.CreatePlaylist("Personal playlist");
        client.AddToPlaylist(album);
        client.AddToPlaylist(song3);
        client.SelectAlbum(0);
        client.Play();
    }
}
