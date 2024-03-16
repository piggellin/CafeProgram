using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeProgram
{
    public class Coffee : IBeverage
    {
        public void Prepare()
        {
            Console.WriteLine("Preparing coffee...");
            Thread.Sleep(1000);
        }
    }
}
