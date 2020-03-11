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
        public List<TimeTable> Routes { get; set; }
        public int AtStationID { get; set; }

        public Train(int id, string name, int maxspeed, bool operated) 
        {
            this.ID = id;
            this.Name = name;
            this.MaxSpeed = maxspeed;
            this.Operated = operated;
        }

        public void AddRouteInstruction(List<TimeTable> routes)
        {            
            foreach(var route in routes)
            {
                if(route.TrainID == this.ID)
                {
                    Routes.Add(route);
                }
            }
        }

        public void ExcecuteInstruction()
        {
            this.AtStationID = Routes[0].StationID;
            Console.WriteLine(AtStationID);
            Routes.Remove(Routes[0]);
        }
    }
}
