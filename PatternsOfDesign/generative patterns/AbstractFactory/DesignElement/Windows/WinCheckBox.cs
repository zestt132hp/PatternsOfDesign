using System;

namespace PatternsOfDesign.generative_patterns.AbstractFactory.DesignElement.Windows
{
    class WinCheckBox:ICheckBox
    {
        public void Paint()
        {
            Console.WriteLine("Painted checkbox in the Windows style");
        }
    }
}
