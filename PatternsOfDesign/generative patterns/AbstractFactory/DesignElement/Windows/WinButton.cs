using System;

namespace PatternsOfDesign.generative_patterns.AbstractFactory.DesignElement.Windows
{
    class WinButton:IButton
    {
        public void Paint()
        {
            Console.WriteLine("Painted button in the Windows style");
        }
    }
}
