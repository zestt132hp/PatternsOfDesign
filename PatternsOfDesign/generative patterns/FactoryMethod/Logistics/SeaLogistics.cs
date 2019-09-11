using PatternsOfDesign.FactoryMethod.Logistics;
using PatternsOfDesign.FactoryMethod.Transport;
using PatternsOfDesign.generative_patterns.FactoryMethod.Transport;

namespace PatternsOfDesign.generative_patterns.FactoryMethod.Logistics
{
    class SeaLogistics:Creator
    {
        public override ITransport CreateTransport()
        {
            return new Ship();
        }
    }
}
