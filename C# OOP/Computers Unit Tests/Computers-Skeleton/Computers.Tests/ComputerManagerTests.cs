using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace Computers.Tests
{
    public class Tests
    {
        Computer computer;
        Computer secondComputer;
        ComputerManager computerManager;
        [SetUp]
        public void Setup()
        {
            computer = new Computer("Dell", "Vostro", 200);
            secondComputer = new Computer("Lenovo", "Legion", 400);
            computerManager = new ComputerManager();
        }

        [Test]
        public void AddsComputer()
        {
            computerManager.AddComputer(computer);
            Assert.AreEqual(computerManager.Computers.Count, 1);
            computerManager.AddComputer(secondComputer);
            Assert.AreEqual(computerManager.Computers.Count, 2);
            computerManager.AddComputer(new Computer("Dell", "Inspirion", 500));
            Assert.AreEqual(computerManager.Computers.Count, 3);
            computerManager.AddComputer(new Computer("Test", "Inspirion", 500));
            Assert.AreEqual(computerManager.Computers.Count, 4);
            computerManager.AddComputer(new Computer(null, "Inspirion", 500));
            Assert.AreEqual(computerManager.Computers.Count, 5);
            Assert.That(computerManager.Computers.Contains(computer));
        }

        [Test]
        public void CantAddNullComputer()
        {
            Assert.That(() => computerManager.AddComputer(null), Throws.ArgumentNullException
                .With.Message.EqualTo("Can not be null! (Parameter 'computer')"));
        }

        [Test]
        public void CantAddExistingComputer()
        {
            computerManager.AddComputer(computer);
            Assert.That(() => computerManager.AddComputer(computer), Throws.ArgumentException
                .With.Message.EqualTo("This computer already exists."));
            Assert.That(() => computerManager.AddComputer(new Computer("Dell", "Vostro", 400)), Throws.ArgumentException
                .With.Message.EqualTo("This computer already exists."));
        }

        [Test]
        public void RemovesComputer()
        {
            computerManager.AddComputer(computer);
            Assert.AreEqual(computerManager.Computers.Count, 1);
            Assert.AreEqual(computerManager.RemoveComputer("Dell", "Vostro"), computer);
            Assert.AreEqual(computerManager.Computers.Count, 0);
        }

        [Test]
        public void CantRemoveComputerWithNullManufacturer()
        {
            Assert.That(() => computerManager.RemoveComputer(null, "Vostro"), Throws.ArgumentNullException
                .With.Message.EqualTo("Can not be null! (Parameter 'manufacturer')"));
        }

        [Test]
        public void CantRemoveComputerWithNullModel()
        {
            Assert.That(() => computerManager.RemoveComputer("Dell", null), Throws.ArgumentNullException
                .With.Message.EqualTo("Can not be null! (Parameter 'model')"));
        }

        [Test]
        public void CantRemoveNonExistingComputer()
        {
            computerManager.AddComputer(computer);
            Assert.That(() => computerManager.RemoveComputer("Lenovo", "Legion"), Throws.ArgumentException
                .With.Message.EqualTo("There is no computer with this manufacturer and model."));
            Assert.That(() => computerManager.RemoveComputer("Apple", "Macbook Pro"), Throws.ArgumentException
                .With.Message.EqualTo("There is no computer with this manufacturer and model."));

        }

        [Test]
        public void GetsExistingComputer()
        {
            computerManager.AddComputer(computer);
            Assert.AreEqual(computerManager.GetComputer("Dell", "Vostro"), computer);
        }

        [Test]
        public void CantGetComputerWithNullManufacturer()
        {
            computerManager.AddComputer(computer);
            Assert.That(() => computerManager.GetComputer(null, "Vostro"), Throws.ArgumentNullException
                .With.Message.EqualTo("Can not be null! (Parameter 'manufacturer')"));
        }

        [Test]
        public void GetsComputersByManufacturer()
        {
            computerManager.AddComputer(computer);
            computerManager.AddComputer(secondComputer);
            var newComputer = new Computer("Dell", "Inspirion", 500);
            computerManager.AddComputer(newComputer);
            Assert.AreEqual(computerManager.GetComputersByManufacturer("Dell").Count, 2);
            Assert.AreEqual(computerManager.GetComputersByManufacturer("Lenovo").Count, 1);
            Assert.AreEqual(computerManager.GetComputersByManufacturer("Test").Count, 0);
        }

        [Test]
        public void CantGetComputersByManufacturerWithNullManufacturer()
        {
            Assert.That(() => computerManager.GetComputersByManufacturer(null), Throws.ArgumentNullException
                .With.Message.EqualTo("Can not be null! (Parameter 'manufacturer')"));
        }

        [Test]
        public void CantGetComputersWithNullManufacturer()
        {
            Assert.That(() => computerManager.GetComputer(null, "Vostro"), Throws.ArgumentNullException
                .With.Message.EqualTo("Can not be null! (Parameter 'manufacturer')"));
            Assert.That(() => computerManager.GetComputer(null, null), Throws.ArgumentNullException
                .With.Message.EqualTo("Can not be null! (Parameter 'manufacturer')"));
        }

        [Test]
        public void CantGetComputerWithNullModel()
        {
            Assert.That(() => computerManager.GetComputer("Dell", null), Throws.ArgumentNullException
                .With.Message.EqualTo("Can not be null! (Parameter 'model')"));
            Assert.That(() => computerManager.GetComputer("", null), Throws.ArgumentNullException
                .With.Message.EqualTo("Can not be null! (Parameter 'model')"));
        }

        [Test]
        public void CantGetNonExistingComputer()
        {
            computerManager.AddComputer(computer);
            computerManager.AddComputer(secondComputer);
            Assert.That(() => computerManager.GetComputer("Dell", "Test"), Throws.ArgumentException
                .With.Message.EqualTo("There is no computer with this manufacturer and model."));
            Assert.That(() => computerManager.GetComputer("Apple", "Macbook Pro"), Throws.ArgumentException
                .With.Message.EqualTo("There is no computer with this manufacturer and model."));
            Assert.That(() => computerManager.GetComputer("Lnovo", "Inspirion"), Throws.ArgumentException
                .With.Message.EqualTo("There is no computer with this manufacturer and model."));
        }

        [Test]
        public void GetByManufacturerReturnsZeroIfManufacturerDoesntExist()
        {
            computerManager.AddComputer(computer);
            computerManager.AddComputer(secondComputer);
            Assert.AreEqual(computerManager.GetComputersByManufacturer("Apple").Count, 0);
            Assert.AreEqual(computerManager.GetComputersByManufacturer("Test").Count, 0);
        }

        [Test]
        public void CountReturnsAccurateNumber()
        {
            Assert.AreEqual(computerManager.Count, 0);
            computerManager.AddComputer(computer);
            Assert.AreEqual(computerManager.Count, 1);
            computerManager.AddComputer(secondComputer);
            Assert.AreEqual(computerManager.Count, 2);
        }

    }
}