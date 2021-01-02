using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Models.Products.Peripherals
{
    public class Monitor : Peripheral, IPeripheral
    {
        public Monitor(int id, string manufacturer, string model, decimal price, double overallPerformance, string connectionType)
            : base(id, manufacturer, model, price, overallPerformance, connectionType)
        {

        }
    }
}
