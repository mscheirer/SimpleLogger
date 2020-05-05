using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using VisioForge.Shared.MediaFoundation.OPM;

namespace SimpleLogger
{
    public class FileLogger : LogBase
    {
        public string filePath = @"D:\IDGLog.txt";
        public override void Log(string message)
        {
            lock (lockObj)
            {
                using (StreamWriter streamWriter = new StreamWriter(filePath))
                {
                    streamWriter.WriteLine(message);
                    streamWriter.Close();
                }
            }
        }
    }
}
