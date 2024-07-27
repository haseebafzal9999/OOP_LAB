using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB._6_Challenge2
{
    internal class Song
    {
        private string songId;
        private string songName;
        private string SingerName;


        public Song(string songId, string songName, string singerName)
        {
            this.songId = songId;
            this.songName = songName;
            SingerName = singerName;
        }
        public void SetSongName(string songname)
        {
            songName = songname;
        }
        public void SetSongId(string songId)
        {
            this.songId = songId;
        }
        public string GetSongName()
        {
            return songName;
        }
        public string GetSongid()
        {
            return songId;
        }
        public void SetSingerName(string name)
        {
            SingerName=name;
        }
        public string GetSingerName()
        {
            return SingerName;
        }
    }
}
