using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeProgram
{
    public class Order
    {
        private List<IBeverage> beverages = new List<IBeverage>();

        public event EventHandler OrderCompleted;

        public void AddBeverage(IBeverage beverage)
        {
            beverages.Add(beverage);
        }

        public void PrepareOrder()
        {
            Console.WriteLine("Placing order...");
            foreach (var beverage in beverages)
            {
                beverage.Prepare();
            }
            OnOrderCompleted();
        }

        protected virtual void OnOrderCompleted()
        {
            OrderCompleted?.Invoke(this, EventArgs.Empty);
        }
    }

}
