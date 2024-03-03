using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlaylist
{
    internal class Song
    {
        private string NameOfTheSong;
        private string Artist;
        private string Type;

        public Song(string nameOfTheSong, string artist, string type)
        {
            NameOfTheSong = nameOfTheSong;
            Artist = artist;
            Type = type;
        }

        public void SetName(string name)
        {
            this.NameOfTheSong = name;

        }

        public string GetNameOfTheSong()
        { return this.NameOfTheSong;
        }


        public void SetArtist(string artist)
        {
            this.Artist = artist;
        }

        public string GetArtist()
        {
            return this.Artist;
        }

        public void SetType(string type)
        {
            this.Type = type;
        }

        public string GetTypeOfSong()
        {
            return this.Type;
        }




    }
}
