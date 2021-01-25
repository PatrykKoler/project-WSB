using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Odtwarzacz
{
    class Player
    {
        public Dictionary<int, Song> Songs { get; set; }

        public void Add(Song song)
        {
            int nrOfSongs = Songs.Count;
            int nextIndex = nrOfSongs + 1;

            Songs.Add(nextIndex, song);
        }

        public void Remove(int songNumber)
        {
            Songs.Remove(songNumber);
        }

        public string Play(int songNumber)
        {
            Song song = Songs[songNumber];

            return song.Play();
        }
    }
}