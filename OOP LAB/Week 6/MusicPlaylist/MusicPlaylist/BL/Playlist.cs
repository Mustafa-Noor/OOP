using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlaylist
{
    internal class Playlist
    {
        private string NameOfPlaylist;
        private List<Song> SongList;

        public Playlist(string nameOfPlaylist, List<Song> songList)
        {
            NameOfPlaylist = nameOfPlaylist;
            SongList = songList;
        }

        public void AddSongIntoList(Song s)
        {
            SongList.Add(s);
        }

        public void SetNameOfPlaylist(string name)
        {
            NameOfPlaylist = name;
        }

        public string GetNameOfPlaylist()
        {
            return NameOfPlaylist;
        }
    }
}
