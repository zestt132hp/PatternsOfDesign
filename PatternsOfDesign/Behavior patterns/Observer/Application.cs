
namespace PatternsOfDesign.Behavior_patterns.Observer
{
    class Application
    {
        private readonly string _fileName = "/path/to/log.txt";
        public Application()
        {
            LoggingListener logger = new LoggingListener(_fileName, "sdkjdgl");
            var editor = new Editor("");
            editor.GetManager.Subscribe(logger);
            var emailAlers = new EmailListener("admin@example.com", "Someone has changed the file: % s");
            editor.GetManager.Subscribe(emailAlers);
        }
    }
}
