using System;
using System.Collections.Generic;
using System.Text;

namespace Railway
{
    public class Track
    {
        public int Id { get; set; }
        public int Length { get; set; }
        public Track(int id, int length) 
        {
            this.Id = id;
            this.Length = length;            
        }
    }

    public class Barrier : Track
    {
        public bool IsOpened { get; set; }

        public Barrier(bool isOpened, int id, int length) : base (id, length)
        {
            this.IsOpened = isOpened;
        }

    }

    public class Switch : Track
    {
        public int PositionedTowards { get; set; }

        public Switch(int positionedTowards, int id, int length) : base(id, length)
        {
            this.PositionedTowards = positionedTowards;
        }
    }
}
