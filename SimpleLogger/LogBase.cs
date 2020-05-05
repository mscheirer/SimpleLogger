using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleLogger
{
    public abstract class LogBase
    {
        protected readonly object lockObj = new object();
        public abstract void Log(string message);
    }
}
