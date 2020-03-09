using System;
using System.Collections.Generic;
using System.Text;

namespace Railway
{
    class Station
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool EndStation { get; set; }

        public Station(int id, string name, bool endstation)
        {
            this.ID = id;
            this.Name = name;
            this.EndStation = endstation;
        }
    }   
}
