using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace Railway
{
   public class Train
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int MaxSpeed { get; set; }
        public bool Operated { get; set; }



        public Train(int id, string name, int maxspeed, bool operated) 
        {
            this.ID = id;
            this.Name = name;
            this.MaxSpeed = maxspeed;
            this.Operated = operated;
        }
    }

    public class TrainBuilder
    {
        const string path= @"/DataFiles/trains.txt";
        public List<Train> Trains { get; } = new List<Train>();
        
       public string[] FetchData()
        {
            return File.ReadAllLines(path);
        }

        public void TrainMapper()
        {
            string[] trainData = FetchData();
            foreach(string line in trainData)
            {
                string[] splitline = line.Split(';',',',':');
                Trains.Add(new Train(int.Parse(splitline[0]), splitline[1], int.Parse(splitline[2]), bool.Parse(splitline[3])));
            }
        }

        
        public TrainBuilder()
        {

        }

    }
}
