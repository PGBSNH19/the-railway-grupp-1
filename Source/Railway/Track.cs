using System;
using System.Collections.Generic;
using System.Text;

namespace Railway
{
    public class Track
    {
        public bool Occupied { get; set; }
        public int Length { get; set; }        

        public Track(bool occupied, int length) 
        {
            this.Occupied = occupied;
            this.Length = length;            
        }
    }

    public class Barrier : Track
    {
        public bool IsOpened { get; set; }

        public Barrier(bool isOpened)
        {

        }

    }

    public class Switch : Track
    {
        public int PositionedTowards { get; set; }
    }
}
