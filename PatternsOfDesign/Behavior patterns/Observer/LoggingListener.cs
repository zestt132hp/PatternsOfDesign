using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PatternsOfDesign.Behavior_patterns.Observer
{
    class LoggingListener:IEventListener
    {
        string _logFileName;
        private string _message;
        private FileStream _log;

        public LoggingListener(string logFileName, string message)
        {
            _logFileName = logFileName;
            _message = message;
        }
        public void Update(string fileName)
        {
            using (_log = File.Open(_logFileName, FileMode.OpenOrCreate))
            {
                _log.Write(Encoding.ASCII.GetBytes(_message));
            }
        }
    }
}
