using System.Collections.Generic;
using System.IO;

namespace Railway
{
    public static class ObjectBuilder
    {
        const string trainDataPath = @"DataFiles/trains.txt";
        const string stationDataPath = @"DataFiles/stations.txt";
        public static List<Train> Trains { get; } = new List<Train>();
        public static List<Station> Stations { get; } = new List<Station>();

        public static string[] FetchData(string path)
        {
            return File.ReadAllLines(path);
        }

        public static void TrainMapper()
        {
            string[] trainData = FetchData(trainDataPath);
            for (int i = 1; i < trainData.Length; i++)
            {
                string[] splitline = trainData[i].Split(';', ',', ':');
                Trains.Add(new Train(int.Parse(splitline[0]), splitline[1], int.Parse(splitline[2]), bool.Parse(splitline[3])));
            }
        }

        public static void StationMapper()
        {
            string[] stationData = FetchData(stationDataPath);
            for (int i = 1; i < stationData.Length; i++)
            {
                string[] splitline = stationData[i].Split(';', ',', ':', '|');
                Stations.Add(new Station(int.Parse(splitline[0]), splitline[1], bool.Parse(splitline[2])));
            }
        }
    }
}
