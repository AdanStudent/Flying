using System;
using System.Collections.Generic;
using System.Text;

namespace Flying
{
    public class Engine
    {
        public bool IsStarted;

        public Engine()
        {
            Stop();
        }

        public string About()
        {
            if (this.IsStarted)
            {
                return String.Format("{0} is {1}", this.GetType(), "started");
            }
            else
            {
                return String.Format("{0} is {1}", this.GetType(), "not started");
            }
        }

        public void Start()
        {
            this.IsStarted = true;

        }

        public void Stop()
        {
            this.IsStarted = false;
        }
    }
}
