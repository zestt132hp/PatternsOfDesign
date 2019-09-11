using System;
using System.Collections.Generic;
using PatternsOfDesign.Behavior_patterns.ChainOfResponsibility;
using PatternsOfDesign.Builder;
using PatternsOfDesign.Builder.Cars;
using PatternsOfDesign.Builder.Manuals;
using PatternsOfDesign.FactoryMethod;
using PatternsOfDesign.FactoryMethod.Transport;
using PatternsOfDesign.generative_patterns.AbstractFactory;
using PatternsOfDesign.generative_patterns.AbstractFactory.DesignElement.MacOS;
using PatternsOfDesign.generative_patterns.AbstractFactory.DesignElement.Windows;
using PatternsOfDesign.generative_patterns.FactoryMethod.Logistics;
using PatternsOfDesign.generative_patterns.Prototype.Shapes;
using PatternsOfDesign.generative_patterns.Singleton;
using PatternsOfDesign.structure_patterns;
using PatternsOfDesign.structure_patterns.Adapter;
using PatternsOfDesign.structure_patterns.Adapter.Peg;
using PatternsOfDesign.structure_patterns.Bridge.Devices;
using PatternsOfDesign.structure_patterns.Bridge.Remotes;
using PatternsOfDesign.structure_patterns.Composite;
using PatternsOfDesign.structure_patterns.Decorator;
using PatternsOfDesign.structure_patterns.Facade;
using PatternsOfDesign.structure_patterns.Proxy;
using Car = PatternsOfDesign.Builder.Cars.Car;
using Circle = PatternsOfDesign.generative_patterns.Prototype.Shapes.Circle;

namespace PatternsOfDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            #region FactoryMethod

            ITransport passengerTransport = new PassengerLogistics().CreateTransport();
            ITransport seaTransport = new SeaLogistics().CreateTransport();
            ITransport roadTransport = new RoadLogistics().CreateTransport();
            passengerTransport.Delivery += PrintEvent;
            seaTransport.Delivery += PrintEvent;
            roadTransport.Delivery += PrintEvent;
            passengerTransport.Transporting();
            seaTransport.Transporting();
            roadTransport.Transporting();

            #endregion

            #region AbstractFactory

            if (args[0] == "Windows")
            {

                IGuiElement element = new CreatorWinElements();

                GuiMaster master = new GuiMaster(element);
                master.CreateElements();
                master.Paint();
            }

            if (args[0] == "Mac")
            {

                IGuiElement element = new CreatorMacElements();

                GuiMaster master = new GuiMaster(element);
                master.CreateElements();
                master.Paint();
            }
            else
            {
                throw new FormatException(nameof(args));
            }

            #endregion

            #region Builder

            CarBuilder builder = new CarBuilder();
            Director director = new Director(builder);
            Car car = builder.GetResult();
            Console.WriteLine(director.ToString());
            CarManualBuilder manualBuilder = new CarManualBuilder();
            director = new Director(manualBuilder);
            Manual manual = manualBuilder.GetResult();
            car.Reset();
            Console.WriteLine(director.ToString());
            manual.Reset();

            #endregion
            
            #region Prototype

            //массив фигур
            Shape[] shapes = new Shape[3];
            //создаем фигуры
            Triangle triangle = new Triangle(12.4, 12.4);
            Rectangle rectangle = new Rectangle(5, 10, "Grey", true);
            Circle circle = new Circle(256.6, true, "Red");
            //кладём в массив
            shapes.SetValue(triangle, 0);
            shapes.SetValue(circle, 1);
            shapes.SetValue(rectangle, 2);

            //создаем копии
            List<Shape> shapesCopy = new List<Shape>(shapes.Length);
            foreach (Shape shape in shapes)
            {
                shapesCopy.Add(shape.Clone());
            }
            #endregion

            #region Singleton

            DataBase db = DataBase.GetInstance();
            db.Query("SELECT ...");

            #endregion

            #region Adapter
                RoundHole hole = new RoundHole(125.5);
                RoundPeg peg = new RoundPeg(175);
                hole.Fits(peg);

                var smallSqpeg = new SquarePage(2);
                var largeSqpeg = new SquarePage(5);
                //hole.Fits(small_sqpeg) // ошибка компиляции, несовместимые типы
                var smallSqpegAdapter = new SquarePegAdapter(smallSqpeg);
                var largeSqpegAdapter = new SquarePegAdapter(largeSqpeg);
                hole.Fits(smallSqpegAdapter);
                hole.Fits(largeSqpegAdapter);

            #endregion

            #region Bridge

            var tv = new Tv();
            var remote = new AdvancedRemote(tv);
            remote.TooglePower();

            var radio = new Radio();
            var remoting = new Remote(radio);
            remoting.ChannelDown();
            #endregion

            #region Composite

            var all = new CompoundGraphic();
            all.Add(new Dot(1, 1));
            all.Add(new structure_patterns.Composite.Circle(5,3,10.5));

            var group = new CompoundGraphic();
            group.Add(new structure_patterns.Composite.Circle(1, 1, 135.4));
            group.Add(new Dot(15,15));
            all.Add(group);

            all.Draw();

            #endregion

            #region Decorator

            var source = new FileDataSource("somefile.dat");
            source.WriteData("salaryrecords");
            var decorator = new CompressionDecorator(source);
            source.WriteData("salaryrecords");
            decorator.Compression();

            #endregion

            #region Facade

            var converter = new VideoConverter();
            var mp4 = converter.Convert("youtubevideo.org", "mp4");
            var fileStream = mp4.OpenRead();
            fileStream.Lock(1,1);
            #endregion

            #region Cache
            Forest forest = new Forest();
            forest.PlantTree(1, 1, "green", "apple", "textture nature");
            forest.PlantTree(2, 1, "green", "pineapple", "nature");
            forest.Draw(new object());
            #endregion

            #region Proxy

            var service = new ThirdPartyYoutubeClass();
            var proxy = new CachedYoutubeClass(service);
            var manager = new YoutubeManager(proxy);
            manager.ReactOnUserInput(123);

            #endregion
            
            #region ChainOfResponsibility

            var dialog = new Dialog("Help Me from Dialog");
            var panel = new Panel("Help me from Panel");
            var ok = new Button("Button Ok help text");
            var cancel = new Button("Button canceled help text");
            panel.Add(ok);
            panel.Add(cancel);
            dialog.Add(panel);
            dialog.ShowHelp();
            #endregion
        }

        private static void PrintEvent(object sender, EventDeliveryArgs e)
        {
            Console.WriteLine($"Transport Mode: {sender.GetType().Name} /n Country: {e.CityName}");
        }
    }
}
