﻿using OnlineShop.Common.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Models.Products.Peripherals
{
    public abstract class Peripheral : Product, IPeripheral
    {
        public string ConnectionType { get; private set; }

        public Peripheral(int id, string manufacturer, string model, decimal price, double overallPerformance, string connectionType)
            : base(id, manufacturer, model, price, overallPerformance)
        {
            ConnectionType = connectionType;
        }

        public override string ToString()
        {
            return base.ToString() + String.Format(SuccessMessages.PeripheralToString, ConnectionType);
        }
    }
}
