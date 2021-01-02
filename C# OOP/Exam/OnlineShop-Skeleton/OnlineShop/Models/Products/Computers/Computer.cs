using OnlineShop.Common.Constants;
using OnlineShop.Models.Products.Components;
using OnlineShop.Models.Products.Peripherals;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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
            private set
            {
                this.components = new List<IComponent>();
            }
        }

        public IReadOnlyCollection<IPeripheral> Peripherals
        {
            get
            {
                return this.peripherals.AsReadOnly();
            }
            private set
            {
                this.components = new List<IComponent>();
            }
        }

        public override double OverallPerformance
        {
            get
            {
                if(Components.Count == 0)
                {
                    return this.overallPerformance;
                }
                else
                {
                    return this.OverallPerformance + GetComponentOverallPerformance();
                }
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidOverallPerformance);
                }
                this.overallPerformance = value;
            }
        }

        public override decimal Price
        {
            get
            {
                return this.price + GetComponentPrice() + GetPeripheralPrice();
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidPrice);
                }
                this.price = value;
            }
        }
        public void AddComponent(IComponent component)
        {
            IComponent containsComponent = this.Components.FirstOrDefault(componentType => componentType.GetType().Name.Equals(component.GetType().Name));
            if(containsComponent != null)
            {
                throw new ArgumentException(ExceptionMessages.ExistingComponent);
            }
            this.components.Add(component);
        }

        public void AddPeripheral(IPeripheral peripheral)
        {
            IPeripheral containsPeripheral = this.Peripherals.FirstOrDefault(peripheralType => peripheralType.GetType().Name.Equals(peripheral.GetType().Name));
            if(containsPeripheral != null)
            {
                throw new ArgumentException(ExceptionMessages.ExistingPeripheral);
            }
            this.peripherals.Add(peripheral);
        }

        public IComponent RemoveComponent(string componentType)
        {
            IComponent containsComponent = this.Components.FirstOrDefault(component => component.GetType().Name.Equals(componentType));
            if (this.Components.Count == 0 || containsComponent == null)
            {
                throw new ArgumentException(ExceptionMessages.NotExistingComponent);
            }
            this.components.Remove(containsComponent);
            return containsComponent;
        }

        public IPeripheral RemovePeripheral(string peripheralType)
        {
            IPeripheral containsPeripheral = this.Peripherals.FirstOrDefault(peripheral => peripheral.GetType().Name.Equals(peripheralType));
            if(this.Peripherals.Count == 0 || containsPeripheral == null)
            {
                throw new ArgumentException(ExceptionMessages.NotExistingPeripheral);
            }
            this.peripherals.Remove(containsPeripheral);
            return containsPeripheral;
        }
        protected Computer(int id, string manufacturer, string model, decimal price, double overallPerformance)
            : base(id, manufacturer, model, price, overallPerformance)
        {
            this.components = new List<IComponent>();
            this.peripherals = new List<IPeripheral>();
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(base.ToString());
            result.AppendLine($" Components: ({this.Components.Count}):");
            foreach(var component in this.Components)
            {
                result.AppendLine($"  {component.GetType().Name}");
            }
            result.AppendLine($" Peripherals: ({this.Peripherals.Count}):");
            foreach(var peripherals in this.Peripherals)
            {
                result.AppendLine($"  {peripherals.GetType().Name}");
            }
            return result.ToString();
        }

        private double GetComponentOverallPerformance()
        {
            double result = 0;
            foreach(var component in this.Components)
            {
                result += component.OverallPerformance;
            }
            return result /= this.Components.Count;
        }

        private decimal GetComponentPrice()
        {
            decimal result = 0;
            foreach(var component in this.Components)
            {
                result += component.Price;
            }
            return result;
        }
        private decimal GetPeripheralPrice()
        {
            decimal result = 0;
            foreach (var peripheral in this.Peripherals)
            {
                result += peripheral.Price;
            }
            return result;
        }
    }
}
