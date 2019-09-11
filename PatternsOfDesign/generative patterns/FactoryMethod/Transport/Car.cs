
using PatternsOfDesign.FactoryMethod;

namespace PatternsOfDesign.generative_patterns.FactoryMethod.Transport
{
    class Car:TransportBase
    {
        public override void Transporting()
        {
            base.Transporting();
            Delivery?.Invoke(this, new EventDeliveryArgs(Country, Status));
        }

        public override event DeliveryHandler Delivery;
    }
}
