﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MusicIdentifier
{
    public class DataPoint
    {
        public int Time { set; get; }
        public int SongID { set; get; }

        public DataPoint(int time, int songID)
        {
            Time = time;
            SongID = songID;
        }

        public override string ToString()
        {
            return "{" + Time.ToString() + "," + SongID.ToString() + "}";
        }
    }
}
