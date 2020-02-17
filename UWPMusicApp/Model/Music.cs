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
        public SoundCategory Category { get; set; }
        public string AudioFile { get; set; }
        public string Imagefile { get; set; }

    }
}
