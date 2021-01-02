using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Models.Products.Peripherals
{
    public class Mouse : Peripheral, IPeripheral
    {
        public Mouse(int id, string manufacturer, string model, decimal price, double overallPerformance, string connectionType)
            : base(id, manufacturer, model, price, overallPerformance, connectionType)
        {

        }
    }
}
