using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odtwarzacz.Entity
{
    class Pop : Song
    {
        public string genre { get; set; }
        public Pop(string title, string author, string genre) : base(title, author, genre)
        {
            this.title = title;
            this.genre = genre;
            this.author = author;
        }
        new public string Play()
        {
            base.Play();
            return $"{title} {author}";
        }
    }
}

