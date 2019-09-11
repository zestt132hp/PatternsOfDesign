using System;

namespace PatternsOfDesign.Behavior_patterns.Observer
{
    class EmailListener:IEventListener
    {
        private readonly string _logFileName;
        private readonly string _message;
        public EmailListener(string logFileName, string message)
        {
            _logFileName = logFileName;
            _message = message;
        }

        public void Update(string fileName)
        {
            Console.WriteLine($"Message sent: {_message}");
        }
    }
}
