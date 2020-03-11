using System;
using System.Collections.Generic;

namespace Railway
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjectBuilder.BuildAll();
            Controller controller = new Controller();
            
            controller.Trains[1].AddRouteInstructions(controller.TimeTables);
            controller.Trains[1].ExcecuteInstruction();
        }
    }
}
