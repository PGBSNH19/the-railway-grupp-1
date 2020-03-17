using System;
using System.Collections.Generic;
using System.Text;

namespace Railway
{
    public class NewTrain
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int MaxSpeed { get; set; }
        public bool Operated { get; set; }

        private readonly ILogComponent LogComponent;
        private readonly IEngineComponent EngineComponent;
        private readonly IPassengerCartComponent PassengerCartComponent;

        public NewTrain(int id, string name, int maxSpeed, bool operated, ILogComponent trainLog,
            IEngineComponent engineComponent,
            IPassengerCartComponent passengerCartComponent)
        {
            this.ID = id;
            this.Name = name;
            this.MaxSpeed = maxSpeed;
            this.Operated = operated;
            this.LogComponent = trainLog;
            this.EngineComponent = engineComponent;
            this.PassengerCartComponent = passengerCartComponent;
        }

        public void StartTrain()
        {
            EngineComponent.Start();
            WriteLogEntry("Engine started.");
        }

        public void StopTrain()
        {
            EngineComponent.Stop();
            WriteLogEntry("Engine stopped.");
        }

        public bool IsRunning()
        {
            return EngineComponent.IsRunning();
        }

        public void WriteLogEntry(string message)
        {
            LogComponent.WriteToLog(message);
        }

        public string ReadLogEntry(int index)
        {
            return LogComponent.GetEntry(index);
        }

        public List<string> GetLog()
        {
            return LogComponent.GetLog();
        }

        public void EmbarkPassengers(int amount)
        {
            PassengerCartComponent.AddPassengers(amount);
            WriteLogEntry
            (
                $"{amount} passengers embarked train.\n" +
                $"{GetPassengerAmount()} currently on train."
            );
        }

        public void DisembarkPassengers(int amount)
        {
            PassengerCartComponent.RemovePassengers(amount);
            WriteLogEntry
            (
                $"{amount} passengers disembarked train.\n" +
                $"{GetPassengerAmount()} currently on train."
            );
        }

        public int GetPassengerAmount()
        {
            return PassengerCartComponent.GetPassengerAmount();
        }
    }
}
