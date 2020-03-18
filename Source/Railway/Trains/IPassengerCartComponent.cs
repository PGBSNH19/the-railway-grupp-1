using System;
using System.Collections.Generic;
using System.Text;

namespace Railway
{
    public interface IPassengerCartComponent
    {
        void RemovePassengers(int amount);
        void AddPassengers(int amount);
        int GetPassengerAmount();
    }
}
