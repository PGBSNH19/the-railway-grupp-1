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
        public List<TimeTable> Routes { get; set; } = new List<TimeTable>();
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

        public void ExcecuteSingleInstruction()
        {
            if (Routes.Any())
            {
                this.AtStationID = Routes[0].StationID;
                Console.WriteLine(AtStationID);
                Routes.Remove(Routes[0]);
            }
            else
            {
                Console.WriteLine($"Train {this.Name} reached end destination and have no further instructions.");
            }
        }

        public void ExcecuteAllInstructions()
        {
            while (Routes.Any())
            {
                if (Routes[0].DepartureTime >= DateTime.Now)
                {
                    Console.WriteLine($"Train {this.Name} departing from {AtStationID} {DateTime.Now.ToString("HH:mm")}");
                    AtStationID = -1;                    
                }
                if (Routes[0].ArrivalTime <= DateTime.Now)
                {
                    this.AtStationID = Routes[0].StationID;
                    Console.WriteLine($"Train {this.Name} arriving at {AtStationID} {DateTime.Now.ToString("HH:mm")}");
                    Routes.Remove(Routes[0]);
                }
                
            }
            Console.WriteLine($"Train {this.Name} reached end destination and have no further instructions.");
        }
    }
}
