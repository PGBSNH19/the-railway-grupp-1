using System;
using System.Collections.Generic;
using System.Text;

namespace Railway
{
    public class Station
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool EndStation { get; set; }
        public int OccupyingTrainID { get; set; }

        public Station(int id, string name, bool endstation, int trainID = -1)
        {
            this.ID = id;
            this.Name = name;
            this.EndStation = endstation;
            this.OccupyingTrainID = trainID;
        }
    }   
}
