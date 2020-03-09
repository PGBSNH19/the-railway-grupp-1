using System;
using System.Collections.Generic;
using System.Text;

namespace Railway
{
   public class TimeTable
    {
        public int TrainID { get; }
        public int StationID { get;}
        public DateTime DepartureTime { get; }
        public DateTime ArrivalTime { get; }

        public TimeTable(int trainId, int stationId, DateTime departureTime, DateTime arrivalTime)
        {
            this.TrainID = trainId;
            this.StationID = stationId;
            this.DepartureTime = departureTime;
            this.ArrivalTime = arrivalTime;
        }
    }
}
