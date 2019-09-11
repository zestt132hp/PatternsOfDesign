using System;

namespace PatternsOfDesign.generative_patterns.AbstractFactory.DesignElement.MacOS
{
    class MacButton:IButton
    {
        public void Paint()
        {
            Console.WriteLine("Painted button in the MacOS style");
        }
    }
}
