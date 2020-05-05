using System;

namespace SimpleLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            LogHelper.Log(LogTarget.File, "Hello");
        }
    }
    public enum LogTarget
    {
        File, Database, EventLogger
    }
}
