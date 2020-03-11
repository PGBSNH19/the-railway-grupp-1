using System;
using System.Collections.Generic;
using System.Text;

namespace Railway
{
    //Carlos
    public class Controller
    {
        public List<Train> Trains { get; } = new List<Train>();
        public List<Station> Stations { get; } = new List<Station>();
        public List<TimeTable> TimeTables { get; } = new List<TimeTable>();
        public List<Passenger> Passengers { get; } = new List<Passenger>();

        public Controller()
        {
            this.Trains = ObjectBuilder.Trains;
            this.Stations = ObjectBuilder.Stations;
            this.TimeTables = ObjectBuilder.TimeTables;
            this.Passengers = ObjectBuilder.Passengers;
        }

    }
}
