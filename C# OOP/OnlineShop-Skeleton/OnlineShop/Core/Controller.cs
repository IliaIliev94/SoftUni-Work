using OnlineShop.Common.Constants;
using OnlineShop.Common.Enums;
using OnlineShop.Models.Products.Components;
using OnlineShop.Models.Products.Computers;
using OnlineShop.Models.Products.Peripherals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineShop.Core
{
    public class Controller : IController
    {
        private List<Computer> computers;
        private List<Component> components;
        private List<Peripheral> peripherals;

        public Controller()
        {
            this.computers = new List<Computer>();
            this.components = new List<Component>();
            this.peripherals = new List<Peripheral>();
        }
        public string AddComponent(int computerId, int id, string componentType, string manufacturer, string model, decimal price, double overallPerformance, int generation)
        {
            ComputerExists(computerId);
            ComponentType componentTypeEnum;
            if(this.components.Any(x => x.Id == id))
            {
                throw new ArgumentException(ExceptionMessages.ExistingComponentId);
            }
            else if(!Enum.TryParse(componentType, out componentTypeEnum))
            {
                throw new ArgumentException(ExceptionMessages.InvalidComponentType);
            }

            Component component = null;
            switch(componentTypeEnum)
            {
                case ComponentType.CentralProcessingUnit:
                    component = new CentralProcessingUnit(id, manufacturer, model, price, overallPerformance, generation);
                    break;
                case ComponentType.Motherboard:
                    component = new Motherboard(id, manufacturer, model, price, overallPerformance, generation);
                    break;
                case ComponentType.PowerSupply:
                    component = new PowerSupply(id, manufacturer, model, price, overallPerformance, generation);
                    break;
                case ComponentType.RandomAccessMemory:
                    component = new RandomAccessMemory(id, manufacturer, model, price, overallPerformance, generation);
                    break;
                case ComponentType.SolidStateDrive:
                    component = new SolidStateDrive(id, manufacturer, model, price, overallPerformance, generation);
                    break;
                case ComponentType.VideoCard:
                    component = new VideoCard(id, manufacturer, model, price, overallPerformance, generation);
                    break;
            }
            computers.FirstOrDefault(x => x.Id == computerId).AddComponent(component);
            components.Add(component);
            return string.Format(SuccessMessages.AddedComponent, componentType, id, computerId);
        }

        public string AddComputer(string computerType, int id, string manufacturer, string model, decimal price)
        {
            ComputerType computerTypeEnum;
            if (computers.Any(computer => computer.Id == id))
            {
                throw new ArgumentException(ExceptionMessages.ExistingComputerId);
            }
            else if(!Enum.TryParse(computerType, out computerTypeEnum))
            {
                throw new ArgumentException(ExceptionMessages.InvalidComputerType);
            }
            Computer computer = null;
            switch (computerTypeEnum)
            {
                case ComputerType.DesktopComputer:
                    computer = new DesktopComputer(id, manufacturer, model, price);
                    break;
                case ComputerType.Laptop:
                    computer = new Laptop(id, manufacturer, model, price);
                    break;
            }
            computers.Add(computer);
            return string.Format(SuccessMessages.AddedComputer, id);
        }

        public string AddPeripheral(int computerId, int id, string peripheralType, string manufacturer, string model, decimal price, double overallPerformance, string connectionType)
        {
            ComputerExists(computerId);
            PeripheralType peripheralTypeEnum;
            if (this.peripherals.Any(x => x.Id == id))
            {
                throw new ArgumentException(ExceptionMessages.ExistingPeripheralId);
            }
            else if (!Enum.TryParse(peripheralType, out peripheralTypeEnum))
            {
                throw new ArgumentException(ExceptionMessages.InvalidPeripheralType);
            }

            Peripheral peripheral = null;
            switch (peripheralTypeEnum)
            {
                case PeripheralType.Headset:
                    peripheral = new Headset(id, manufacturer, model, price, overallPerformance, connectionType);
                    break;
                case PeripheralType.Keyboard:
                    peripheral = new Keyboard(id, manufacturer, model, price, overallPerformance, connectionType);
                    break;
                case PeripheralType.Monitor:
                    peripheral = new Monitor(id, manufacturer, model, price, overallPerformance, connectionType);
                    break;
                case PeripheralType.Mouse:
                    peripheral = new Mouse(id, manufacturer, model, price, overallPerformance, connectionType);
                    break;
            }
            computers.FirstOrDefault(x => x.Id == computerId).AddPeripheral(peripheral);
            peripherals.Add(peripheral);
            return string.Format(SuccessMessages.AddedPeripheral, peripheralType, id, computerId);
        }

        public string BuyBest(decimal budget)
        {
            Computer computer = computers.OrderByDescending(x => x.OverallPerformance).Where(x => x.Price <= budget).ToList().FirstOrDefault();
            if(computer == null)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.CanNotBuyComputer, budget));
            }
            computers.Remove(computer);
            return computer.ToString();
        }

        public string BuyComputer(int id)
        {
            ComputerExists(id);
            Computer computer = computers.FirstOrDefault(x => x.Id == id);
            computers.Remove(computer);
            return computer.ToString();
        }

        public string GetComputerData(int id)
        {
            ComputerExists(id);
            Computer computer = computers.FirstOrDefault(x => x.Id == id);
            return computer.ToString();
        }

        public string RemoveComponent(string componentType, int computerId)
        {
            ComputerExists(computerId);
            Component component = (Component)computers.FirstOrDefault(x => x.Id == computerId).RemoveComponent(componentType);
            components.Remove(components.FirstOrDefault(component => component.GetType().Name == componentType));
            return string.Format(SuccessMessages.RemovedComponent, componentType, component.Id);
        }

        public string RemovePeripheral(string peripheralType, int computerId)
        {
            ComputerExists(computerId);
            Peripheral peripheral = (Peripheral)computers.FirstOrDefault(x => x.Id == computerId).RemovePeripheral(peripheralType);
            peripherals.Remove(peripherals.FirstOrDefault(peripheral => peripheral.GetType().Name == peripheralType));
            return string.Format(SuccessMessages.RemovedPeripheral, peripheralType, peripheral.Id);
        }

        public void ComputerExists(int id)
        {
            if(!computers.Any(computer => computer.Id == id))
            {
                throw new ArgumentException(ExceptionMessages.NotExistingComputerId);
            }
        }
    }
}
