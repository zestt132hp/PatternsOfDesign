
namespace PatternsOfDesign.FactoryMethod.Transport
{
    interface ITransport: IStatus
    {
        void Transporting();
        bool DeliveryStatus();
        string CountryName();
    }
}
