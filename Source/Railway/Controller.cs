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
        public void OperateTrain(int trainID, ClockSimulator clock)
        {
            Train train = ObjectBuilder.Trains.First(t => t.ID == trainID);
            train.AddRouteInstruction(ObjectBuilder.TimeTables);
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
                    Console.WriteLine($"Log {train.Name} : {train.TrainLog.Last()}");
                    lastLogMessage = train.TrainLog.Last();
                }
                train.ExcecuteSingleInstruction(clockSim.GetTime());
               

            }

            Console.WriteLine($"Log {train.Name} : {train.TrainLog.Last()}");
            train.ExcecuteSingleInstruction(clockSim.GetTime());
            Console.WriteLine(train.TrainLog.Last());
            lastLogMessage = train.TrainLog.Last();

        }
    }
}
