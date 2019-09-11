
using PatternsOfDesign.FactoryMethod;
using PatternsOfDesign.FactoryMethod.Transport;

namespace PatternsOfDesign.generative_patterns.FactoryMethod.Transport
{
    abstract class TransportBase:ITransport
    {
        public virtual void Transporting() { }
        protected bool Status;
        protected int MaxSpeed;
        protected string Country;
        protected object[,] Mapping;

        public bool DeliveryStatus() => Status;

        public string CountryName() => Country;
        public virtual event DeliveryHandler Delivery;
    }
}
