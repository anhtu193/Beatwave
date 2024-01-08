using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beatwave
{
    public class SongInfo
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public byte[] Cover { get; set; }
        public TimeSpan Duration { get; set; }
        public string Path { get; set; }
    }
}
