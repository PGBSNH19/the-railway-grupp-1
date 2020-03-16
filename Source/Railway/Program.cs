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
            Controller controller = new Controller();
            ObjectBuilder.BuildAll();
            DateTime startTime = new DateTime();
            startTime = startTime.Date + new TimeSpan(10, 15, 0);

            ClockSimulator sim = new ClockSimulator(startTime, 1000, 60);
            sim.StartClock();

            controller.OperateTrain(2, sim);
            controller.OperateTrain(3, sim);
        }
    }
}
