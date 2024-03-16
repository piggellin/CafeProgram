using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeProgram
{
    public class BeverageFactory
    {
        public IBeverage CreateBeverage(string type)
        {
            switch (type.ToLower())
            {
                case "coffee":
                    return new Coffee();
                case "tea":
                    return new Tea();
                case "smoothie":
                    return new Smoothie();
                default:
                    throw new ArgumentException($"Unsupported beverage type: {type}");
            }
        }
    }
}
