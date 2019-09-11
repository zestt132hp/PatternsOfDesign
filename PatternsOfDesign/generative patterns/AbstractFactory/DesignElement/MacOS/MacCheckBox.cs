using System;

namespace PatternsOfDesign.generative_patterns.AbstractFactory.DesignElement.MacOS
{
    class MacCheckBox:ICheckBox
    {
        public void Paint()
        {
            Console.WriteLine("Painted checkbox in the Mac OS style");
        }
    }
}
