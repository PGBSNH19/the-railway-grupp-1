using System;

namespace Railway
{
    class Program
    {
        static void Main(string[] args)
        {

            ObjectBuilder.BuildAll();

            foreach (var element in ObjectBuilder.Stations)
            {
                Console.WriteLine($"{element.ID} : {element.Name}");
            }

            foreach (var element in ObjectBuilder.Trains)
            {
                Console.WriteLine($"{element.ID} : {element.Name}");
            }

            foreach (var element in ObjectBuilder.TimeTables)
            {
                Console.WriteLine($"{element.TrainID} : {element.StationID} : {element.ArrivalTime}");
            }

            foreach (var element in ObjectBuilder.Passengers)
            {
                Console.WriteLine($"{element.ID} : {element.Name}");
            }
        }
    }
}
