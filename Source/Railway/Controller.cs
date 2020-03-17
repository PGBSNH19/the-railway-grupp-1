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
        private List<TimeTable> timeTable = ObjectBuilder.TimeTableMapper();
        public void OperateTrain(int trainID, ClockSimulator clock)
        {
            Train train = ObjectBuilder.Trains.First(t => t.ID == trainID);
            AddRouteInstruction(timeTable, train);
            Thread trainThr = new Thread(() => StartTrain(train, clock));
            trainThr.Start();
        }

        public void StartTrain(Train train, ClockSimulator clockSim)
        {
            string lastLogMessage = "";
           
            while (train.Routes.Any())
            {
                if (train.TrainLog.Last() != lastLogMessage)
                {
                    PrintTrainLogToConsole(clockSim.TimeToString(), train.Name, train.TrainLog.Last());
                    lastLogMessage = train.TrainLog.Last();
                }
                ExcecuteSingleInstruction(clockSim.GetDateTime(), train);              
            }

            PrintTrainLogToConsole(clockSim.TimeToString(), train.Name, train.TrainLog.Last());
            ExcecuteSingleInstruction(clockSim.GetDateTime(), train);
            PrintTrainLogToConsole(clockSim.TimeToString(), train.Name, train.TrainLog.Last());
        }

        public void PrintTrainLogToConsole(string time, string trainName, string logMessage)
        {

            Console.WriteLine($"Log {time} : {trainName} : {logMessage}");
        }

        public void SetWorldTime(ClockSimulator clockSim, TimeSpan time) 
        {
            clockSim.SetTime(time);
        }

            public void ExcecuteSingleInstruction(DateTime time, Train train)
            {
            if (train.Routes.Any())
            {
                if (time.TimeOfDay >= train.Routes[0].DepartureTime.TimeOfDay && !train.IsRunning)
                {
                    train.TrainLog.Add($"{time.ToShortTimeString()} : Departing station {train.AtStationID} for {train.Routes[0].ArrStationID}.");
                    train.Depart();
                }
                else if (time.TimeOfDay >= train.Routes[0].ArrivalTime.TimeOfDay && train.IsRunning)
                {
                    train.Arrive(train.Routes[0].ArrStationID);
                    train.TrainLog.Add($"{time.ToShortTimeString()} : Arriving at station {train.AtStationID}.");
                    train.Routes.Remove(train.Routes[0]);
                }
            }
            else
            {
                train.TrainLog.Add("Awaiting further instructions...");
            }
        }

        public void AddRouteInstruction(List<TimeTable> routes, Train train)
        {
            foreach (var route in routes)
            {
                if (routes.Any() && route.TrainID == train.ID)
                {
                    
                        train.Routes.Add(route);
                        train.AtStationID = routes[0].DepStationID;
                    
                }
            }
        }
    }
}
