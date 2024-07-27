using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2_Week6
{
    internal class Song
    {
        private string SongName;
        private int SongID;
        private string SingerName;

        public Song() { }
        public Song(string songName, int songID, string singerName)
        {
            SongName = songName;
            SongID = songID;
            SingerName = singerName;
        }

        public void setSongName(string songName)
        {
            SongName = songName;
        }
        public string getSongName()
        {
            return SongName;
        }
        public void setSongID(int songId)
        {
            SongID = songId;
        }
        public int getSongId()
        {
            return SongID;
        }
        public void setSingerName(string singerName)
        {
            SingerName = singerName;
        }
        public string getSingerName()
        {
            return SingerName;
        }
    }
}
