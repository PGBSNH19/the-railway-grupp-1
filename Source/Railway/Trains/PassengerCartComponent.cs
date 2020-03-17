using System;
using System.Collections.Generic;
using System.Text;

namespace Railway
{
    public class PassengerCartComponent : IPassengerCartComponent
    {
        private int passengerAmount;

        public PassengerCartComponent(int passengers = 0)
        {
            passengerAmount = passengers;
        }

        public virtual void AddPassengers(int amount)
        {
            passengerAmount += amount;
        }

        public virtual void RemovePassengers(int amount)
        {
            if (passengerAmount - amount < 0)
            {
                passengerAmount = 0;
            }
            else
            {
                passengerAmount -= amount;
            }            
        }

        public virtual int GetPassengerAmount()
        {
            return passengerAmount;
        }
    }
}
