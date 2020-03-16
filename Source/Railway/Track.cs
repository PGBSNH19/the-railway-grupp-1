using System;
using System.Collections.Generic;
using System.Text;

namespace Railway
{
    public class Track
    {
        public bool Occupied { get; set; }
        public int Length { get; set; }
        public int Switch { get; set; }
        public bool Barrier { get; set; }

        public Track(bool occupied, int length, int tswitch, bool barrier) {
            this.Occupied = occupied;
            this.Length = length;
            this.Switch = tswitch;
            this.Barrier = barrier;
        }
    }
}
