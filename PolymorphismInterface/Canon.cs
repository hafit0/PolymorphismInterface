using System;

namespace PolymOR2
{
    class Canon : IPrinterWindows
    {
        public void Show()
        {
            Console.WriteLine("Canon Display dimension : 9.5*12");
        }
        public void Print()
        {
            Console.WriteLine("Canon Printer Printing....  ");
        }
    }
}
