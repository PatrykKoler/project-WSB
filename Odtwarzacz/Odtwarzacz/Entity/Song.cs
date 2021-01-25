using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odtwarzacz
{
    class Song
    {
        public string  title { get; set; }
        public string author { get; set; }
        public string  genre { get; set; }

        public Song(string title, string author, string genre)
        {
            this.title = title;        
            this.author = author;
            this.genre = genre;
        }
        public string Play()
        {
            return $"{title} {author}";
        }

    }
}
