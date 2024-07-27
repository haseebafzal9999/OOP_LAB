using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB._6_Challenge2
{
    internal class Playlist
    {
        private string PlaylistName;
        private string PlaylistId;
        private List<Song> Songlist=new List<Song>();
        public Playlist(string PlaylistName,string PlaylistId, List<Song> Songlist) 
        { 
            this.PlaylistName = PlaylistName;
            this.PlaylistId = PlaylistId;
           this.Songlist = Songlist;
        }
        public Playlist() { }
        public void SetPlaylistName(string name)
        {
            PlaylistName =name;
        }
        public void SetPlaylistId(string id)
        {
            PlaylistId=id;  
        }

        public string GetPlaylistName()
        {
            return PlaylistName;
        }
        public string GetPlaylistId()
        {
            return PlaylistId;
        }
        // For Aggregation::-
        /* public void SetSongList(List<Song> songList)
         {
             Songlist = songList;
         }*/
        //For Composition:-
        public void AddSong(string songName, string singerName, string songId)
        {
            Song newSong = new Song(songId, songName, singerName);
            Songlist.Add(newSong);
        }
        public List<Song> GetSongList()
        {
            return Songlist;
        }

       





    }
}
