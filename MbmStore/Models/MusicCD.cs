using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class MusicCD : Product
    {

        private List<Track> tracks = new List<Track>();
        public List<Track> Tracks { get { return tracks; } }
        public string Artist { get; set; }
        public string Label { get; set; }
        public short Publiced { get; set; }

        public TimeSpan GetPlayingTime ()
        {
            TimeSpan totaltime = new TimeSpan();
            foreach (Track Tra in tracks) { 
                totaltime += Tra.Length;
                    }
            return totaltime;
        }
       

        public MusicCD() { }
        public MusicCD (string artist,string title, decimal price, short released, string imageurl) : base(title, price, imageurl)
        {
            Artist = artist;
            Publiced = released;
            
        }

        
        public void AddTracks (Track track)
        {
            tracks.Add(track);
                }
    }
}
