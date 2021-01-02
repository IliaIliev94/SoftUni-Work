using OnlineShop.Models.Products.Components;
using OnlineShop.Models.Products.Peripherals;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using OnlineShop.Common.Constants;

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
                if(this.components.Count == 0)
                {
                    return base.OverallPerformance;
                }
                return base.OverallPerformance + AverageOfComponents();
            }

        }

        public override decimal Price
        {
            get
            {
                return base.Price + components.Sum(x => x.Price) + peripherals.Sum(x => x.Price);
            }
        }

        public void AddComponent(IComponent component)
        {
            if (components.Any(x => x.GetType().Name == component.GetType().Name))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.ExistingComponent, component.GetType().Name, this.GetType().Name, this.Id));
            }
            components.Add(component);
        }

        public void AddPeripheral(IPeripheral peripheral)
        {
            if (peripherals.Any(x => x.GetType().Name == peripheral.GetType().Name))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.ExistingPeripheral, peripheral.GetType().Name, this.GetType().Name, this.Id));
            }
            peripherals.Add(peripheral);
        }

        public IComponent RemoveComponent(string componentType)
        {
            if(components.Count == 0 || !components.Any(x => x.GetType().Name == componentType))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.NotExistingComponent, componentType, this.GetType().Name, this.Id));
            }
            IComponent component = this.components.FirstOrDefault(x => x.GetType().Name == componentType);
            components.Remove(component);
            return component;
        }

        public IPeripheral RemovePeripheral(string peripheralType)
        {
            if (peripherals.Count == 0 || !peripherals.Any(x => x.GetType().Name == peripheralType))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.NotExistingPeripheral, peripheralType, this.GetType().Name, this.Id));
            }
            IPeripheral peripheral = this.peripherals.FirstOrDefault(x => x.GetType().Name == peripheralType);
            peripherals.Remove(peripheral);
            return peripheral;
        }

        public Computer(int id, string manufacturer, string model, decimal price, double overallPerformance)
            : base(id, manufacturer, model, price, overallPerformance)
        {
            this.components = new List<IComponent>();
            this.peripherals = new List<IPeripheral>();
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(base.ToString());
            result.AppendLine($" {string.Format(SuccessMessages.ComputerComponentsToString, this.components.Count)}");
            for (int i = 0; i < this.components.Count; i++)
            {
                if(i != this.components.Count - 1)
                {
                    result.AppendLine($"  {components[i].ToString()}");
                }
                else
                {
                    result.AppendLine($"  {components[i].ToString()}");
                }
            }
            result.AppendLine($" {string.Format(SuccessMessages.ComputerPeripheralsToString, this.peripherals.Count, $"{AverageOfPeripherals():F2}")}");
            for(int i = 0; i < this.peripherals.Count; i++)
            {
                if(i != this.peripherals.Count - 1)
                {
                    result.AppendLine($"  {peripherals[i].ToString()}");
                }
                else
                {
                    result.Append($"  {peripherals[i].ToString()}");

                }
            }
            return result.ToString();
        }
        private double AverageOfComponents()
        {
            double result = 0;
            if (this.components.Count == 0)
            {
                return result;
            }
            return this.components.Sum(x => x.OverallPerformance) / this.components.Count;
         }
        private double AverageOfPeripherals()
        {
            double result = 0;
            if (this.peripherals.Count == 0)
            {
                return result;
            }
            return this.peripherals.Sum(x => x.OverallPerformance) / this.peripherals.Count;
        }
    }


}
