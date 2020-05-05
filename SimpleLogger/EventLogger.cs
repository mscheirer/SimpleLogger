using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleLogger
{
    public class EventLogger : LogBase
    {
        private string v;

        public EventLogger(string v)
        {
            this.v = v;
        }

        public string Source { get; private set; }

        public override void Log(string message)
        {
            lock (lockObj)
            {
                EventLogger m_EventLog = new EventLogger("");
                m_EventLog.Source = "IDGEventLog";
                m_EventLog.WriteEntry(message);
            }
        }

        private void WriteEntry(string message)
        {
            throw new NotImplementedException();
        }
    }
}
