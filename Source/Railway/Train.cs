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

        

        public void Depart()
        {
            AtStationID = -1;
            IsRunning = true;
        }

        public void Arrive(int stationID)
        {
            AtStationID = stationID;
            IsRunning = false;
        }
    }
}
