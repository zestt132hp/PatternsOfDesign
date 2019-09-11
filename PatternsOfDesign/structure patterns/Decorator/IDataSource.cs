

namespace PatternsOfDesign.structure_patterns.Decorator
{
    interface IDataSource
    {
        void WriteData(object data);
        object ReadData();
    }
}
