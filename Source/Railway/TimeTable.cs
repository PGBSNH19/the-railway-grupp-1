using System;
using System.Collections.Generic;
using System.Text;

namespace Railway
{
    public class TimeTable
    {
        public int TrainID { get; }
        public int DepStationID { get; }
        public DateTime DepartureTime { get; }
        public int ArrStationID { get; }
        public DateTime ArrivalTime { get; }

        public TimeTable(int trainId, int depStationId, DateTime departureTime, int arrStationId, DateTime arrivalTime)
        {
            this.TrainID = trainId;
            this.DepStationID = depStationId;
            this.DepartureTime = departureTime;
            this.ArrStationID = arrStationId;
            this.ArrivalTime = arrivalTime;
        }
    }
}
