using OnlineShop.Models.Products.Computers;
using OnlineShop.Models.Products.Peripherals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Linq;
using OnlineShop.Common.Constants;
using OnlineShop.Models.Products;
using OnlineShop.Models.Products.Components;

namespace OnlineShop.Core
{
    public class Controller : IController
    {
        private List<IComputer> computersCollection;
        private List<IProduct> components;
        private List<IProduct> peripherals;
        public string AddComponent(int computerId, int id, string componentType, string manufacturer, string model, decimal price, double overallPerformance, int generation)
        {
            ComputerExists(id);
            IProduct componentExists = components.FirstOrDefault(component => component.Id == id);
            if(componentExists != null)
            {
                throw new ArgumentException(ExceptionMessages.ExistingComponent);
            }
            OnlineShop.Models.Products.Components.IComponent component = null;
            switch (componentType)
            {
                case "Motherboard":
                    component = new Motherboard(id, manufacturer, model, price, overallPerformance, generation);
                    break;
                case "PowerSupply":
                    component = new PowerSupply(id, manufacturer, model, price, overallPerformance, generation);
                    break;
                case "RandomAccessMemory":
                    component = new RandomAccessMemory(id, manufacturer, model, price, overallPerformance, generation);
                    break;
                case "CentralProcessingUnit":
                    component = new CentralProcessingUnit(id, manufacturer, model, price, overallPerformance, generation);
                    break;
                case "VideoCard":
                    component = new VideoCard(id, manufacturer, model, price, overallPerformance, generation);
                    break;
            }
            if(component == null)
            {
                throw new ArgumentException(ExceptionMessages.InvalidComponentType);
            }
            components.Add(component);
            computersCollection.FirstOrDefault(x => x.Id == computerId).AddComponent(component);
            return $"Component { componentType } with id { id} added successfully in computer with id { computerId}.";
        }

        public string AddComputer(string computerType, int id, string manufacturer, string model, decimal price)
        {
            IComputer computer = null;
            switch(computerType)
            {
                case "DesktopComputer":
                    computer = new DesktopComputer(id, manufacturer, model, price);
                    break;
                case "laptop":
                    computer = new Laptop(id, manufacturer, model, price);
                    break;
            }

            if(computer == null)
            {
                throw new ArgumentException(ExceptionMessages.InvalidComputerType);
            }
            return $"Computer with id {id} added successfully.";
        }

        public string AddPeripheral(int computerId, int id, string peripheralType, string manufacturer, string model, decimal price, double overallPerformance, string connectionType)
        {
            ComputerExists(id);
            IProduct componentExists = peripherals.FirstOrDefault(component => component.Id == id);
            if (componentExists != null)
            {
                throw new ArgumentException(ExceptionMessages.ExistingComponent);
            }
            OnlineShop.Models.Products.Peripherals.IPeripheral component = null;
            switch (peripheralType)
            {
                case "Headset":
                    component = new Headset(id, manufacturer, model, price, overallPerformance, connectionType);
                    break;
                case "Keyboard":
                    component = new Keyboard(id, manufacturer, model, price, overallPerformance, connectionType);
                    break;
                case "Monitor":
                    component = new Monitor(id, manufacturer, model, price, overallPerformance, connectionType);
                    break;
                case "Mouse":
                    component = new Mouse(id, manufacturer, model, price, overallPerformance, connectionType);
                    break;
            }
            if (component == null)
            {
                throw new ArgumentException(ExceptionMessages.InvalidPeripheralType);
            }
            peripherals.Add(component);
            computersCollection.FirstOrDefault(x => x.Id == computerId).AddPeripheral(component);
            return $"Peripheral {peripheralType} with id {id} added successfully in computer with id {computerId}.";
        }

        public string BuyBest(decimal budget)
        {
            throw new NotImplementedException();
        }

        public string BuyComputer(int id)
        {
            throw new NotImplementedException();
        }

        public string GetComputerData(int id)
        {
            throw new NotImplementedException();
        }

        public string RemoveComponent(string componentType, int computerId)
        {
            computersCollection.FirstOrDefault(x => x.Id == computerId).RemoveComponent(componentType);
            IProduct product = components.FirstOrDefault(x => x.GetType().Name == componentType);
            components.Remove(product);
            return $"Successfully removed {product.GetType().Name} with id {product.Id}";
        }

        public string RemovePeripheral(string peripheralType, int computerId)
        {
            computersCollection.FirstOrDefault(x => x.Id == computerId).RemovePeripheral(peripheralType);
            IProduct product = peripherals.FirstOrDefault(x => x.GetType().Name == peripheralType);
            peripherals.Remove(product);
            return $"Successfully removed {product.GetType().Name} with id {product.Id}";
        }

        public Controller()
        {
            this.computersCollection = new List<IComputer>();
            this.components = new List<IProduct>();
            this.peripherals = new List<IProduct>();
        }
        private void ComputerExists(int id)
        {
            IComputer computerExists = computersCollection.FirstOrDefault(computer => computer.Id == id);
            if(computerExists == null)
            {
                throw new ArgumentException(ExceptionMessages.ExistingComputerId);
            }
        }
    }
}
