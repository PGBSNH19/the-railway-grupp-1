using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Threading;

namespace Railway
{
    public class Train
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int MaxSpeed { get; set; }
        public bool Operated { get; set; }
        public bool IsRunning { get; set; }
        public List<TimeTable> Routes { get; set; } = new List<TimeTable>();
        public int AtStationID { get; set; }
        public List<string> TrainLog { get; } = new List<string>();

        public Train(int id, string name, int maxspeed, bool operated) 
        {
            this.ID = id;
            this.Name = name;
            this.MaxSpeed = maxspeed;
            this.Operated = operated;
            TrainLog.Add("Ready to recieve instructions...");
        }

        public void AddRouteInstruction(List<TimeTable> routes)
        {
            foreach (var route in routes)
            {
                if (route.TrainID == this.ID)
                {
                    if (Routes.Any())
                    {
                        Routes.Add(route);
                    }
                    else
                    {
                        Routes.Add(route);
                        AtStationID = Routes[0].DepStationID;
                    }
                }
            }
        }

        private void Depart()
        {
            AtStationID = -1;
            IsRunning = true;
        }

        private void Arrive(int stationID)
        {
            AtStationID = stationID;
            IsRunning = false;
        }

        public void ExcecuteSingleInstruction(DateTime time)
        {
            if (Routes.Any())
            {
                if (time.TimeOfDay >= Routes[0].DepartureTime.TimeOfDay && !IsRunning)
                {
                    TrainLog.Add($"{time.ToShortTimeString()} : Departing station {AtStationID} for {Routes[0].ArrStationID}.");
                    Depart();
                }
                else if (time.TimeOfDay >= Routes[0].ArrivalTime.TimeOfDay && IsRunning)
                {
                    Arrive(Routes[0].ArrStationID);
                    TrainLog.Add($"{time.ToShortTimeString()} : Arriving at station {AtStationID}.");
                    Routes.Remove(Routes[0]);
                }
            }
            else
            {
                TrainLog.Add("Awaiting further instructions...");
            }
        }
    }
}
