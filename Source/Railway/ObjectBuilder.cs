using System;
using System.Collections.Generic;
using System.IO;

namespace Railway
{
    public static class ObjectBuilder
    {
        const string trainDataPath = @"DataFiles/trains.txt";
        const string stationDataPath = @"DataFiles/stations.txt";
        const string timeTableDataPath = @"DataFiles/timetable.txt";
        const string passengersDataPath = @"DataFiles/passengers.txt";
        public static List<Train> Trains { get; } = new List<Train>();
        public static List<Station> Stations { get; } = new List<Station>();
        public static List<TimeTable> TimeTables { get; } = new List<TimeTable>();
        public static List<Passenger> Passengers { get; } = new List<Passenger>();


        public static string[] FetchData(string path)
        {
            return File.ReadAllLines(path);
        }

        public static void BuildAll()
        {
            TrainMapper();
            StationMapper();
            PassengerMapper();
        }

        public static void TrainMapper()
        {
            string[] trainData = FetchData(trainDataPath);
            for (int i = 1; i < trainData.Length; i++)
            {
                string[] splitline = trainData[i].Split(';', ',', ':');
                Trains.Add(new Train(
                    int.Parse(splitline[0]), 
                    splitline[1], 
                    int.Parse(splitline[2]),
                    bool.Parse(splitline[3]),
                    new LogComponent(),
                    new EngineComponent(),
                    new PassengerCartComponent()));
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


        public static List<TimeTable> TimeTableMapper()
        {
            string[] timeTableData = FetchData(timeTableDataPath);
            List<TimeTable> timeTable = new List<TimeTable>();
            for (int i = 1; i < timeTableData.Length; i++)
            {
                string[] splitline = timeTableData[i].Split(';', ',', '|');
                timeTable.Add(new TimeTable(int.Parse(splitline[0]), int.Parse(splitline[1]), DateTime.Parse(splitline[2]), int.Parse(splitline[3]), DateTime.Parse(splitline[4])));
            }
            return timeTable;
        }

        public static void PassengerMapper()
        {
            string[] passengerData = FetchData(passengersDataPath);
            for (int i = 1; i < passengerData.Length; i++)
            {
                string[] splitline = passengerData[i].Split(';', ',', ':', '|');
                Passengers.Add(new Passenger(int.Parse(splitline[0]), splitline[1]));
            }
        }
    }
}
