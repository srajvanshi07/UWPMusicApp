using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWPMusicApp.Model
{
    public class Music
    {
        // public string Pop { get; set; }
        //public string Jazz { get; set; }
        // public string Rock { get; set; }
        //public string HipHop { get; set; }
        //public string  Classical { get; set; }
        //public string International { get; set; }
        public string Name { get; set; }
        public MusicCategory Category { get; set; }
        public string AudioFile { get; set; }
        public string Imagefile { get; set; }


        //Create enum type
        public enum MusicCategory
        {
                //Pop,
               // Jazz,
                Rock,
                //HipHop,
                Country,
                Classical,
                International
        }
         //Create constuctor:
        public Music(string name, MusicCategory category)
        {
            Name = name;
            Category = category;
            AudioFile = $"/Assets/Music/{category}/{name}.mp3";
            Imagefile = $"/Assets/Images/{category}/{name}.jpeg";
        }
    }
}
