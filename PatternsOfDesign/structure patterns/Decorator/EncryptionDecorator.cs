
namespace PatternsOfDesign.structure_patterns.Decorator
{
    class EncryptionDecorator:DataSourceDecorator
    {
        private IDataSource _dataSource;
        public EncryptionDecorator(IDataSource dataSource) : base(dataSource)
        {
            _dataSource = dataSource;
        }

        public void Encryption(object data)
        {
            //do encryption data then call base method writeData
            var encrypt = "";
            _dataSource.WriteData(encrypt);
        }

        public object Decryption()
        {
            //do encryption data then return data;
            object s = _dataSource.ReadData();
            return s;
        }

    }
}
