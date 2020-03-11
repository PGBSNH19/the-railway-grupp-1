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
        public Station CurrentStation { get; set; }
        public Station ArrivingStation { get; set; }
        public List<TimeTable> OperationInstructions { get; set; }

        public Train(int id, string name, int maxspeed, bool operated) 
        {
            this.ID = id;
            this.Name = name;
            this.MaxSpeed = maxspeed;
            this.Operated = operated;
        }

        public void AddRouteInstruction(List<TimeTable> instructions)
        {
            
            OperationInstructions = instructions.Where(i => i.TrainID == this.ID).ToList();

        }

        public void ExcecuteInstruction()
        {
            foreach (var instruction in OperationInstructions)
            {   
                   Console.WriteLine("Train is departing from current Station)
            }
        }
    }
}
