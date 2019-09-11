using System;
using System.Threading;
using System.Threading.Tasks;
using PatternsOfDesign.FactoryMethod;
using PatternsOfDesign.FactoryMethod.Transport;

namespace PatternsOfDesign.generative_patterns.FactoryMethod.Transport
{
    class Ship : TransportBase, IStatus
    {
        public override event DeliveryHandler Delivery;

        public Ship()
        {
            MaxSpeed = 28;
            Mapping = new object[,]
                {{"Ukraine", 0},{"China", 7600}, {"USA", 7790}, {"Japan", 8455}, {"Turkey", 833}, {"Greece", 1100}};
        }

        public Ship(object[,] mapping, int maxSpeed)
        {
            Mapping = mapping;
            MaxSpeed = maxSpeed;
        }

        public override async void Transporting() => await Task.Run(DoTransporting);

        private void DoTransporting()
        {
            if (Status)
            {
                return;
            }

            for (int i = 1; i < Mapping.GetLength(0); i++)
            {
                for (int j = 0; j < Mapping.GetLength(1); j++)
                {
                    if (i == 0 && j == 0)
                    {
                        continue;
                    }

                    if (Int32.TryParse(Mapping[i, j].ToString(), out var s))
                    {
                        Int32.TryParse(Mapping[i, j - 1].ToString(), out var prvS);
                        Thread.Sleep(Math.Abs(prvS - s)/MaxSpeed * 100);
                        Status = true;
                        Country = Mapping[0, j].ToString();
                        Delivery?.Invoke(this, new EventDeliveryArgs(Country, Status));
                    }
                }
            }

        }
    }
}
