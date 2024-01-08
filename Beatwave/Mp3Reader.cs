using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beatwave
{
    public class Mp3Reader
    {
        public List<SongInfo> GetSongsInfo(string folderPath)
        {
            List<SongInfo> songs = new List<SongInfo>();

            try
            {
                string[] mp3Files = Directory.GetFiles(folderPath, "*.mp3");

                foreach (string mp3File in mp3Files)
                {
                    SongInfo song = new SongInfo();

                    using (TagLib.File mp3 = TagLib.File.Create(mp3File))
                    {
                        song.Title = mp3.Tag.Title;
                        song.Artist = mp3.Tag.Performers.Length > 0 ? mp3.Tag.Performers[0] : "";
                        song.Album = mp3.Tag.Album;
                        song.Cover = mp3.Tag.Pictures.Length > 0 ? mp3.Tag.Pictures[0].Data.Data : null;
                        song.Duration = mp3.Properties.Duration;
                        song.Path = mp3File;

                        songs.Add(song);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return songs;
        }
    }
}
