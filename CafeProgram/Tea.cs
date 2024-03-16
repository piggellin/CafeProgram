using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeProgram
{
    public class Tea : IBeverage
    {
        public void Prepare()
        {
            Console.WriteLine("Preparing tea...");
            Thread.Sleep(1000);
        }
    }
}
