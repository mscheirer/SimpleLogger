using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleLogger
{
    public static class LogHelper
    {
        private static LogBase logger = null;
        public static void Log(LogTarget target, string message)
        {
            switch (target)
            {
                case LogTarget.File:
                    logger = new FileLogger();
                    logger.Log(message);
                    break;
                case LogTarget.Database:
                    logger = new DBLogger();
                    logger.Log(message);
                    break;
                case LogTarget.EventLogger:
                    logger = new EventLogger(message);
                    logger.Log(message);
                    break;
                default:
                    return;
            }
        }
    }
}
