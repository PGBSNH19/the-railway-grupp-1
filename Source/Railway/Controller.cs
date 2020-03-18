using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading;

namespace Railway
{
    //Han heter Carlos 
    public class Controller
    {
        private ClockSimulator clockSim = new ClockSimulator(100, 60);
        private List<TimeTable> timeTable = ObjectBuilder.TimeTableMapper();

        public Controller()
        {
            clockSim.SetTime(new TimeSpan(10, 00, 00));
            clockSim.StartClock();
        }

        public void OperateTrain(Train train)
        {
            Thread trainThr = new Thread(() => Start(train, timeTable, clockSim));
            trainThr.Start();
        }

        public void Start(Train train, List<TimeTable> timeTable, ClockSimulator clockSim)
        {
            timeTable = timeTable.Where(x => x.TrainID == train.ID).ToList();

            while (timeTable.Any())
            {
                if (!train.IsRunning() && timeTable[0].DepartureTime.TimeOfDay <= clockSim.GetDateTime().TimeOfDay)
                {
                    train.StartTrain();
                    Console.WriteLine($"Log {clockSim.TimeToString()} : {train.Name} : departing from {ObjectBuilder.Stations.Find(s => s.ID == timeTable[0].DepStationID).Name} station");
                }
                if (train.IsRunning() && timeTable[0].ArrivalTime.TimeOfDay <= clockSim.GetDateTime().TimeOfDay)
                {
                    train.StopTrain();
                    Console.WriteLine($"Log {clockSim.TimeToString()} : {train.Name} : arriving at {ObjectBuilder.Stations.Find(s => s.ID == timeTable[0].ArrStationID).Name} station");
                    timeTable.Remove(timeTable[0]);
                }
            }
        }

        public void PrintTrainLogToConsole(string time, string trainName, string logMessage)
        {
            Console.WriteLine($"Log {time} : {trainName} : {logMessage}");
        }
    }
}
