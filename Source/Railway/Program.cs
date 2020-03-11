using System;
using System.Collections.Generic;
using System.Threading;

namespace Railway
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjectBuilder.BuildAll();
            Controller controller = new Controller();
            // Thread train1 = new Thread();

            controller.Trains[1].AddRouteInstruction(controller.TimeTables);
            controller.Trains[1].ExcecuteAllInstructions();

            controller.clock();
        }
    }
}
