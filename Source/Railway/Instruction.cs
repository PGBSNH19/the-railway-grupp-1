using System;
using System.Collections.Generic;
using System.Text;

namespace Railway
{
    public class Instruction
    {
        public int ArrivalStationID { get; }
        public DateTime ArrivalTime { get; }

        public Instruction(int stnID, DateTime arrivalTime)
        {
            this.ArrivalStationID = stnID;
            this.ArrivalTime = arrivalTime;
        }


    }
}
