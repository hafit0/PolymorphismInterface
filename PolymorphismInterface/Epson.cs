
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymOR2
{
    class Epson : IPrinterWindows
    {
        public void Show()
        {
            Console.WriteLine("Epson Display dimension : 10*11");
        }
        public void Print()
        {
            Console.WriteLine("Epson Printer Printing....  ");
        }
    }
}
