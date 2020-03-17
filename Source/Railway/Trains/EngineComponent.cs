using System;
using System.Collections.Generic;
using System.Text;

namespace Railway
{
    class EngineComponent : IEngineComponent
    {
        private bool isRunning;

        public EngineComponent()
        {
            isRunning = false;
        }

        public virtual void Start()
        {
            isRunning = true;
        }

        public virtual void Stop()
        {
            isRunning = false;
        }

        public virtual bool IsRunning()
        {
            return isRunning;
        }
    }
}
