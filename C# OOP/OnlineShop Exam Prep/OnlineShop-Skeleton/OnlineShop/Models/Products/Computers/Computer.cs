using OnlineShop.Common.Constants;
using OnlineShop.Models.Products.Components;
using OnlineShop.Models.Products.Peripherals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineShop.Models.Products.Computers
{
    public abstract class Computer : Product, IComputer
    {
        private List<IComponent> components;
        private List<IPeripheral> peripherals;
        public IReadOnlyCollection<IComponent> Components
        {
            get
            {
                return this.components.AsReadOnly();
            }
        }

        public IReadOnlyCollection<IPeripheral> Peripherals
        {
            get
            {
                return this.peripherals.AsReadOnly();
            }
        }

        public override double OverallPerformance
        {
            get
            {
                if(components.Count <= 0)
                {
                    return base.OverallPerformance;
                }
                return base.OverallPerformance + (components.Sum(component => component.OverallPerformance) / components.Count);
            }
        }

        public override decimal Price
        {
            get
            {
                return base.Price + components.Sum(component => component.Price) + peripherals.Sum(peripheral => peripheral.Price);
            }
        }

        public void AddComponent(IComponent component)
        {
            var componentType = component.GetType().Name;
            if (components.Any(existingComponent => existingComponent.GetType().Name.Equals(componentType)))
            {
                throw new ArgumentException(String.Format(ExceptionMessages.ExistingComponent, componentType, this.GetType().Name, this.Id));
            }
            components.Add(component);
        }

        public void AddPeripheral(IPeripheral peripheral)
        {
            var peripheralType = peripheral.GetType().Name;
            if (peripherals.Any(existingComponent => existingComponent.GetType().Name.Equals(peripheralType)))
            {
                throw new ArgumentException(String.Format(ExceptionMessages.ExistingPeripheral, peripheralType, this.GetType().Name, this.Id));
            }
            peripherals.Add(peripheral);
        }

        public IComponent RemoveComponent(string componentType)
        {
            IComponent component = components.FirstOrDefault(component => component.GetType().Name == componentType);
            if(component == null)
            {
                throw new ArgumentException(String.Format(ExceptionMessages.NotExistingComponent, componentType, this.GetType().Name, this.Id));
            }
            components.Remove(component);
            return component;
        }

        public IPeripheral RemovePeripheral(string peripheralType)
        {
            IPeripheral peripheral = peripherals.FirstOrDefault(peripheral => peripheral.GetType().Name == peripheralType);
            if (peripheral == null)
            {
                throw new ArgumentException(String.Format(ExceptionMessages.NotExistingPeripheral, peripheralType, this.GetType().Name, this.Id));
            }
            peripherals.Remove(peripheral);
            return peripheral;
        }

        public Computer(int id, string manufacturer, string model, decimal price, double overallPerformance) :
            base(id, manufacturer, model, price, overallPerformance)
        {
            components = new List<IComponent>();
            peripherals = new List<IPeripheral>();
        }

        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            res.AppendLine(base.ToString());
            res.AppendLine($" Components ({components.Count}):");
            foreach(var component in components)
            {
                res.AppendLine($"  {component.ToString()}");
            }
            res.AppendLine($" Peripherals ({peripherals.Count}); Average Overall Performance ({GetPeripheralsAverage().ToString("0.00")}):");
            foreach (var peripheral in peripherals)
            {
                res.AppendLine($"  {peripheral.ToString()}");
            }
            return res.ToString().Trim();
        }

        private double GetPeripheralsAverage()
        {
            if(peripherals.Count == 0)
            {
                return 0;
            }
            return peripherals.Sum(peripheral => peripheral.OverallPerformance) / peripherals.Count;
        }
    }
}
