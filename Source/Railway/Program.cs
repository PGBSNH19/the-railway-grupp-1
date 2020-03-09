using System;

namespace Railway
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjectBuilder.TrainMapper();
            
            foreach(var element in ObjectBuilder.Trains)
            {
                Console.WriteLine($"{element.ID} : {element.Name}");
            }

            ObjectBuilder.StationMapper();

            foreach (var element in ObjectBuilder.Stations)
            {
                Console.WriteLine($"{element.ID} : {element.Name}");
            }
        }
    }
}
