using System;

namespace PatternsOfDesign.FactoryMethod
{
    public delegate void DeliveryHandler(object sender, EventDeliveryArgs e);
    public class EventDeliveryArgs : EventArgs
    {
        public string CityName { get;}
        public bool Status { get; }

        public EventDeliveryArgs(string cityName, bool status)
        {
            Status = status;
            CityName = cityName;
        }
    }
}
