using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeProgram
{
    public class Cashier
    {
        public void PlaceOrder(Order order)
        {
            order.PrepareOrder();
        }
    }
}
