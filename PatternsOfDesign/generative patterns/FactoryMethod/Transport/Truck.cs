using PatternsOfDesign.FactoryMethod;
using PatternsOfDesign.FactoryMethod.Transport;

namespace PatternsOfDesign.generative_patterns.FactoryMethod.Transport
{
    class Truck:TransportBase, IStatus
    {
        public override event DeliveryHandler Delivery;

        public override void Transporting()
        {
            base.Transporting();
            Delivery?.Invoke(this, new EventDeliveryArgs(Country, Status));
        }
    }
}
