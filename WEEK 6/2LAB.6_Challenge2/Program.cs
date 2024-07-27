using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB._6_Challenge2
{
    internal class Program
    {
        static void Main(string[] args)

         { 
                Playlist playList = new Playlist();
                playList.SetPlaylistName("Haseeb Afzal");
                playList.SetPlaylistId("1");
            // For Aggregation::-
              // Song newsong = new Song("abc", "cde/*", "fgh");
              //Song newsong2 = new Song("as", "qwe", "ghj");
                /*List<Song> SongList = new List<Song>();
                 SongList.Add(newsong);
                 SongList.Add(newsong2);*/
             //  playList.SetSongList(SongList);

             // For composition::-
             playList.AddSong("BestSong", "Ali","1");
               playList.AddSong("Rana song", "Imran khan","2");

               List<Song> songs = playList.GetSongList();
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", playList.GetPlaylistName(), playList.GetPlaylistId(), songs[0].GetSongName(), songs[1].GetSongName());
                Console.ReadLine();
          
        }
    }
}
