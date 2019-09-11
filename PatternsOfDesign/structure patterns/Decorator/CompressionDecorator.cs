
namespace PatternsOfDesign.structure_patterns.Decorator
{
    class CompressionDecorator:DataSourceDecorator
    {
        private IDataSource _dataSource;
        public CompressionDecorator(IDataSource dataSource) : base(dataSource)
        {
            _dataSource = dataSource;
        }

        public void Compression()
        {
            var compressData = _dataSource.ReadData();
            _dataSource.WriteData(compressData);

        }

        public object Decompression()
        {
            var deCompressData = _dataSource.ReadData();
            return deCompressData;
        }
    }
}
