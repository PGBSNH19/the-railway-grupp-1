using System;
using System.Collections.Generic;
using System.Text;

namespace Railway
{
    public interface ILogWriter
    {
        void WriteToLog(string message);
    }

    public interface ILogReader
    {
        string GetEntry(int index);
        List<string> GetLog();
    }

    public interface ILogComponent : ILogReader, ILogWriter
    {

    }
}
