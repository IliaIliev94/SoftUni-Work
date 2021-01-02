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
        private List<Peripheral> peripherals;
        private List<Component> components;

        public Controller()
        {
            computers = new List<Computer>();
            components = new List<Component>();
            peripherals = new List<Peripheral>();
        }
        public string AddComponent(int computerId, int id, string componentType, string manufacturer, string model, decimal price, double overallPerformance, int generation)
        {
            ComputerExists(computerId);
            Component component = components.FirstOrDefault(component => component.Id == id);
            if(component != null)
            {
                throw new ArgumentException(ExceptionMessages.ExistingComponentId);
            }
            switch(componentType)
            {
                case "CentralProcessingUnit":
                    component = new CentralProcessingUnit(id, manufacturer, model, price, overallPerformance, generation);
                    break;
                case "Motherboard":
                    component = new Motherboard(id, manufacturer, model, price, overallPerformance, generation);
                    break;
                case "PowerSupply":
                    component = new PowerSupply(id, manufacturer, model, price, overallPerformance, generation);
                    break;
                case "RandomAccessMemory":
                    component = new RandomAccessMemory(id, manufacturer, model, price, overallPerformance, generation);
                    break;
                case "SolidStateDrive":
                    component = new SolidStateDrive(id, manufacturer, model, price, overallPerformance, generation);
                    break;
                case "VideoCard":
                    component = new VideoCard(id, manufacturer, model, price, overallPerformance, generation);
                    break;
                default:
                    throw new ArgumentException(ExceptionMessages.InvalidComponentType);
            }
            components.Add(component);
            computers.FirstOrDefault(computer => computer.Id == computerId).AddComponent(component);
            return String.Format(SuccessMessages.AddedComponent, componentType, id, computerId);
        }

        public string AddComputer(string computerType, int id, string manufacturer, string model, decimal price)
        {
            Computer computer = computers.FirstOrDefault(computer => computer.Id == id);
            if(computer != null)
            {
                throw new ArgumentException(ExceptionMessages.ExistingComputerId);
            }
            switch(computerType)
            {
                case "DesktopComputer":
                    computer = new DesktopComputer(id, manufacturer, model, price);
                    break;
                case "Laptop":
                    computer = new Laptop(id, manufacturer, model, price);
                    break;
                default:
                    throw new ArgumentException(ExceptionMessages.InvalidComputerType);
            }
            computers.Add(computer);
            return String.Format(SuccessMessages.AddedComputer, id);
        }

        public string AddPeripheral(int computerId, int id, string peripheralType, string manufacturer, string model, decimal price, double overallPerformance, string connectionType)
        {
            ComputerExists(computerId);
            Peripheral peripheral = peripherals.FirstOrDefault(peripheral => peripheral.Id == id);
            if (peripheral != null)
            {
                throw new ArgumentException(ExceptionMessages.ExistingPeripheralId);
            }
            switch (peripheralType)
            {
                case "Headset":
                    peripheral = new Headset(id, manufacturer, model, price, overallPerformance, connectionType);
                    break;
                case "Keyboard":
                    peripheral = new Keyboard(id, manufacturer, model, price, overallPerformance, connectionType);
                    break;
                case "Monitor":
                    peripheral = new Monitor(id, manufacturer, model, price, overallPerformance, connectionType);
                    break;
                case "Mouse":
                    peripheral = new Mouse(id, manufacturer, model, price, overallPerformance, connectionType);
                    break;
                default:
                    throw new ArgumentException(ExceptionMessages.InvalidPeripheralType);
            }
            peripherals.Add(peripheral);
            computers.FirstOrDefault(computer => computer.Id == computerId).AddPeripheral(peripheral);
            return String.Format(SuccessMessages.AddedPeripheral, peripheralType, id, computerId);
        }

        public string BuyBest(decimal budget)
        {
            List<Computer> sortedComputers = computers.Where(computer => computer.Price <= budget)
                .OrderByDescending(computer => computer.OverallPerformance).ToList();
            if(sortedComputers.Count <= 0)
            {
                throw new ArgumentException(String.Format(ExceptionMessages.CanNotBuyComputer, budget));
            }
            Computer computer = sortedComputers[0];
            computers.Remove(computer);
            return computer.ToString();
        }

        public string BuyComputer(int id)
        {
            ComputerExists(id);
            Computer computer = computers.FirstOrDefault(computer => computer.Id == id);
            computers.Remove(computer);
            return computer.ToString();
        }

        public string GetComputerData(int id)
        {
            ComputerExists(id);
            Computer computer = computers.FirstOrDefault(computer => computer.Id == id);
            return computer.ToString();
        }

        public string RemoveComponent(string componentType, int computerId)
        {
            ComputerExists(computerId);
            Component component = components.FirstOrDefault(component => component.GetType().Name.Equals(componentType));
            components.Remove(component);
            computers.FirstOrDefault(computer => computer.Id == computerId).RemoveComponent(componentType);
            return String.Format(SuccessMessages.RemovedComponent, componentType, component.Id);
        }

        public string RemovePeripheral(string peripheralType, int computerId)
        {
            ComputerExists(computerId);
            Peripheral peripheral = peripherals.FirstOrDefault(peripheral => peripheral.GetType().Name.Equals(peripheralType));
            peripherals.Remove(peripheral);
            computers.FirstOrDefault(computer => computer.Id == computerId).RemovePeripheral(peripheralType);
            return String.Format(SuccessMessages.RemovedPeripheral, peripheralType, peripheral.Id);
        }

        private void ComputerExists(int computerId)
        {
            if(!computers.Any(computer => computer.Id == computerId))
            {
                throw new ArgumentException(ExceptionMessages.NotExistingComputerId);
            }
        }
    }
}
