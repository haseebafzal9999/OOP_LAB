using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2_Week6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayList playList= new PlayList();
            playList.setPlayListID(1);
            playList.AddSong("KSK", "Shan",1);
            playList.AddSong("lhK", "Sahb",2);
            List<Song> songs = playList.getSongList();
            Console.WriteLine("{0}\t{1}\t{2}", playList.getPlayListID(), songs[0].getSongName(), songs[1].getSongName());
            Console.ReadLine();
        }
    }
}
