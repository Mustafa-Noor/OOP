using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlaylist
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // AS AGGREGATION
            List <Song> Songs = new List <Song> ();

            Song s = new Song("Song1", "Jake", "Pop");
            Song s2 = new Song("Song2", "Jake", "Jazz");

            Songs.Add (s);
            Songs.Add (s2);

            Playlist p = new Playlist("Best Songs", Songs);



        }
    }
}
