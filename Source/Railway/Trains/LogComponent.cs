using System;
using System.Collections.Generic;
using System.Text;

namespace Railway
{
    public class LogComponent : ILogComponent
    {
        public int TrainID { get; set; }
        private List<string> log = new List<string>();

        public LogComponent(int trainID)
        {
            this.TrainID = trainID;
        }

        public virtual void WriteToLog(string message)
        {
            log.Add(message);
        }

        public virtual string GetEntry(int index)
        {
            return log[index];
        }

        public virtual List<string> GetLog()
        {
            return log;
        }
    }
}
