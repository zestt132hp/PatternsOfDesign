
namespace PatternsOfDesign.structure_patterns.Decorator
{
    class FileDataSource:IDataSource
    {
        private string _fileName;
        public FileDataSource(string fileName)
        {
            _fileName = fileName;
        }
        public void WriteData(object data)
        {
            //writing data in file
        }

        public object ReadData()
        {
            //reading data from file
            return null;
        }
    }
}
