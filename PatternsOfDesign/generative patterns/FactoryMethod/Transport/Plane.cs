using System;
using System.Threading;
using System.Threading.Tasks;
using PatternsOfDesign.FactoryMethod;
using PatternsOfDesign.FactoryMethod.Transport;

namespace PatternsOfDesign.generative_patterns.FactoryMethod.Transport
{
    class Plane:TransportBase, IStatus
    {
        public Plane(object[,] mapping, int maxSpeed)
        {
            MaxSpeed = maxSpeed;
            Mapping = mapping ?? throw new NullReferenceException(nameof(mapping));
        }

        public Plane()
        {
            Mapping = new object[,] {{"Moldova", "Russia", "Ukraine", "Poland", "Belarus"}, {0, 1250, 350, 895, 700}};
            MaxSpeed = 350;
        }


        public override async void Transporting() => await Task.Run(DoTransportation);
        
        private void DoTransportation()
        {
            if (Status)
                return;
            for (int i = 1; i < Mapping.GetLength(0); i++)
            {
                Country = Mapping[i, 0].ToString();
                for (int j = 0; j < Mapping.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        break;
                    }

                    if (Int32.TryParse(Mapping[i, j].ToString(), out var s))
                    {
                        Thread.Sleep(s/MaxSpeed * 100);
                    }

                    Status = true;
                    Country = Mapping[0, j].ToString();

                    Delivery?.Invoke(this, new EventDeliveryArgs(Country, Status));
                }
            }
        }

        public override event DeliveryHandler Delivery;
    }

  
}
