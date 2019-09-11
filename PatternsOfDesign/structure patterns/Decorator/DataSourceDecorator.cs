

namespace PatternsOfDesign.structure_patterns.Decorator
{
    class DataSourceDecorator:IDataSource
    {
        private IDataSource _dataSource;

        public DataSourceDecorator(IDataSource dataSource)
        {
            _dataSource = dataSource;
        }
        public void WriteData(object data)
        {
            _dataSource.WriteData(data);
        }

        public object ReadData()
        {
            return _dataSource.ReadData();
        }
    }
}
