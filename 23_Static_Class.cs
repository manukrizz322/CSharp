using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public class Song
    {
        public string title;
        public string artist;
        public static int songCount = 0;

        public Song(string title, string artist)
        {
            this.title = title;
            this.artist = artist;
            songCount++;
        }
    }
}
