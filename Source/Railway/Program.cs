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
        }
    }
}
