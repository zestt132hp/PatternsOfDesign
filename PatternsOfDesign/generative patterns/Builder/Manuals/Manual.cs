using System;

namespace PatternsOfDesign.Builder.Manuals
{
    class Manual
    {
        public void Reset()
        {
            Console.WriteLine("Сброс мануала");
        }

        public void SetSeats(int count)
        {
            Console.WriteLine("В машине установлены сидения для удобного расположения пассажиров, \n хотя их можно было складировать как дрова :)");
        }

        public void SetEngine()
        {

            Console.WriteLine("В автомобиле установлен двигатель с минимальным 1000 объемом");
        }

        public void SetGps()
        {

            Console.WriteLine("Если нужно GPS - пожалуйста");
        }

        public void SetMonitor()
        {

            Console.WriteLine("Нужен мониор? - пожалуйста");
        }
    }
}
