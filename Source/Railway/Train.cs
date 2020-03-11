using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace Railway
{
    public class Train
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int MaxSpeed { get; set; }
        public bool Operated { get; set; }
        public Station LastVisitedStation { get; set; }
        public Station ArrivingStation { get; set; }
        public List<TimeTable> OperationInstructions { get; }

        public Train(int id, string name, int maxspeed, bool operated) 
        {
            this.ID = id;
            this.Name = name;
            this.MaxSpeed = maxspeed;
            this.Operated = operated;
        }

        public void AddRouteInstruction(TimeTable instruction)
        {
            OperationInstructions.Add(instruction);
        }
    }
}
