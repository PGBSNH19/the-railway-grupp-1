using System;

namespace Railway
{
    class Program
    {
        static void Main(string[] args)
        {
            TrainBuilder.TrainMapper();
            
            foreach(var element in TrainBuilder.Trains)
            {
                Console.WriteLine($"{element.ID} : {element.Name}");
            }
        }
    }
}
