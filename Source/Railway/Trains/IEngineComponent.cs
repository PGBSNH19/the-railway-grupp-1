using System;
using System.Collections.Generic;
using System.Text;

namespace Railway
{
    public interface IEngineComponent
    {
        void Start();
        void Stop();
        bool IsRunning();
    }
}
