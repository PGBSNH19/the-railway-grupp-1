using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;

namespace Railway
{
    class Program
    {

        static void Main(string[] args)
        {
            ClockSimulator sim = new ClockSimulator(100, 60);
            sim.StartClock();
            Controller controller = new Controller();
            ObjectBuilder.BuildAll();

            controller.OperateTrain(ObjectBuilder.Trains[1]);
            controller.OperateTrain(ObjectBuilder.Trains[2]);

            //controller.Main();

            //Controller.SetWorldTime();



            //controller.OperateTrain(2, sim);
            //controller.OperateTrain(3, sim);

            //NewTrain train = ObjectBuilder.Trains[1];
            //train.StartTrain();
            //Console.WriteLine(train.IsRunning());
            //train.StopTrain();
            //Console.WriteLine(train.IsRunning());
            //train.EmbarkPassengers(10);
            //train.DisembarkPassengers(5);
            //foreach (var entry in train.GetLog())
            //{
            //    Console.WriteLine(entry);
            //}

        }
    }
}
