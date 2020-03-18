using System;
using System.Collections.Generic;
using System.Text;

namespace Railway
{
    public class Passenger
    {
        public int ID { get; }
        public string Name { get; }

        public Passenger(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }

    }
}
