using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

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

        public void MoveTrainTo(Train train, Station station)
        {
            station.OccupyingTrainID = train.ID;
            train.AtStationID = station.ID;
        }

        public void clock()
        {
            Timer timer = new Timer(1000);
            
            timer.Elapsed += upDateClock;
            timer.AutoReset = true;
            timer.Enabled = true;
            timer.Start();
        }

        public void upDateClock(object source, ElapsedEventArgs e)
        {
            Console.WriteLine("Hej Hampus");
        }
    }
}
