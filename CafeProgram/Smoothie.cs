using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeProgram
{
    public class Smoothie : IBeverage
    {
        public void Prepare()
        {
            Console.WriteLine("Preparing smoothie...");
            Thread.Sleep(1000);
        }
    }
}
