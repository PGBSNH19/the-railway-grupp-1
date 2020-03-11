using System;
using System.Collections.Generic;
using System.Threading;

namespace Railway
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread time = new Thread(new ThreadStart(ObjectBuilder.BuildAll));
            time.Start();
            
            ObjectBuilder.BuildAll();
            Controller controller = new Controller();
            // Thread train1 = new Thread();
            Console.WriteLine(controller.Stations[0].Name);
            controller.Trains[1].AddRouteInstruction(controller.TimeTables);
            controller.Trains[1].ExcecuteAllInstructions();
        }
    }
}
