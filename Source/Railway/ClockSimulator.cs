using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Railway
{
    public class ClockSimulator
    {
        private DateTime time;
        private bool IsRunning = false;
        public Thread clockRun;
        public int SecondsAddedPerTick { get; set; }
        public int MillisecPerTick { get; set; }

        public ClockSimulator(DateTime setTime, int millisecPerTick, int secondsAddedPerTick = 1)
        {
            this.time = setTime;
            this.MillisecPerTick = millisecPerTick;
            this.SecondsAddedPerTick = secondsAddedPerTick;
        }

        public void StartClock()
        {
            IsRunning = true;

            clockRun = new Thread(RunClock);
            clockRun.Name = "clockRunThread";
            clockRun.Start();
        }

        private void RunClock()
        {
            while (IsRunning)
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
            IsRunning = false;
        }

        public DateTime GetTime()
        {
            return time;
        }
    }
}
