﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static UWPMusicApp.Model.Music;

namespace UWPMusicApp.Model
{
    public class MenuItem
    {
        public string IconFile { get; set;}
        public MusicCategory  Category { get; set; }
    }
}
