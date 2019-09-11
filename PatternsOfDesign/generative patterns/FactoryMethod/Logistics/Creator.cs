using PatternsOfDesign.FactoryMethod.Transport;

namespace PatternsOfDesign.FactoryMethod.Logistics
{
    abstract class Creator
    {
        public abstract ITransport CreateTransport();
    }
}
