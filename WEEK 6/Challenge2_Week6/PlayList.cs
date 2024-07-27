using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2_Week6
{
    internal class PlayList
    {
        private int PlayListID;

        private List<Song> SongList;

        public PlayList() { 
        SongList = new List<Song>();
        }   

        public void setPlayListID(int PlayListID)
        {
            this.PlayListID = PlayListID;
        }
        public int getPlayListID()
        {
            return PlayListID;
        }
       /* public void setSongList(List<Song> songList)
        {
            SongList = songList;
        }*/
        public List<Song> getSongList()
        {
            return SongList;
        }
        public void AddSong(string songName,string singerName,int songId)
        {
            Song newSong=new Song(songName,songId,singerName);
            SongList.Add(newSong);
        }
    }
}
