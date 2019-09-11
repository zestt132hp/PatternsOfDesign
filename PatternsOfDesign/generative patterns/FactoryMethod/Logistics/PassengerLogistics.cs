using PatternsOfDesign.FactoryMethod.Logistics;
using PatternsOfDesign.FactoryMethod.Transport;
using PatternsOfDesign.generative_patterns.FactoryMethod.Transport;

namespace PatternsOfDesign.generative_patterns.FactoryMethod.Logistics
{
    class PassengerLogistics:Creator
    {
        public override ITransport CreateTransport()
        {
            return new Car();
        }
    }
}
