using System;
using System.IO;
using System.Text;

namespace PatternsOfDesign.Behavior_patterns.Observer
{
    class Editor
    {
        private readonly EventManager _manager;
        private readonly string _fileName;
        private FileStream _file;
        public Editor(string fileName)
        {
            _manager = new EventManager();
            _fileName = fileName;
        }

        public void WriteFile(string info)
        {
            using (_file = File.Open(_fileName, FileMode.OpenOrCreate))
            {
                byte[] bytes = Encoding.ASCII.GetBytes(_fileName);
                _file.Write(bytes, 5, bytes.Length);
                _manager.Notify(_fileName);
            }
        }

        public void ReadFile()
        {
            _file = File.OpenRead(_fileName);
            byte[] vytes= new byte[_file.Length];
            _file.ReadAsync(vytes, 0, Int32.MaxValue);
            _manager.Notify(_fileName);
        }
        public EventManager GetManager=>_manager;
    }
}
