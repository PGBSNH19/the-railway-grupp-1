using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Railway
{
    public class ClockSimulator
    {
        private DateTime time;
        private bool isRunning = false;
        public Thread clockRun;
        public int SecondsAddedPerTick { get; set; }
        public int MillisecPerTick { get; set; }

        public ClockSimulator(int millisecPerTick, int secondsAddedPerTick = 1, DateTime setTime = new DateTime())
        {
            this.time = setTime;
            this.MillisecPerTick = millisecPerTick;
            this.SecondsAddedPerTick = secondsAddedPerTick;
        }

        public void SetTime(TimeSpan timeOfDay)
        {
            time = time.Date + timeOfDay;
        }

        public void StartClock()
        {
            isRunning = true;

            clockRun = new Thread(RunClock);
            clockRun.Name = "clockRunThread";
            clockRun.Start();
        }

        private void RunClock()
        {
            while (isRunning)
            {
                IncreaseSeconds(SecondsAddedPerTick);
                Thread.Sleep(MillisecPerTick);
            }
        }

        private void IncreaseSeconds(int secondIncrease = 1)
        {
            if (secondIncrease < 1) secondIncrease = 1;
            this.time = time.AddSeconds(secondIncrease);
        }

        public void StopClock()
        {
            isRunning = false;
        }

        public DateTime GetDateTime()
        {
            return time;
        }

        public string TimeToString()
        {
            return time.ToShortTimeString();
        }

        public bool IsRunning()
        {
            return isRunning;
        }
    }
}
