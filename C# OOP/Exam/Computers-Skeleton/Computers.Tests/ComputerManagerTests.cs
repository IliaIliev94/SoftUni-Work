using NUnit.Framework;
using System.Collections;
using System.Linq;

namespace Computers.Tests
{
    public class Tests
    {
        private ComputerManager computerManager;
        [SetUp]
        public void Initialize()
        {
            computerManager = new ComputerManager();
        }

        [Test]
        public void CannotAddNullComputer()
        {
            Computer computer = null;
            Assert.That(() => computerManager.AddComputer(computer), Throws.ArgumentNullException.With.Message.EqualTo("Can not be null! (Parameter 'computer')"));
        }
        [Test]
        public void AddsComputer()
        {
            Computer computer = new Computer("Dell", "Vostro", 50);
            computerManager.AddComputer(computer);
            Assert.That(computerManager.Computers.Contains(computer));
        }

        [Test]
        public void CannotAddSameComputerTwice()
        {
            Computer computer1 = new Computer("Dell", "Vostro", 50);
            Computer computer2 = new Computer("Dell", "Vostro", 20);
            computerManager.AddComputer(computer1);
            Assert.That(() => computerManager.AddComputer(computer2), Throws.ArgumentException.With.Message.EqualTo("This computer already exists."));
        }

        [Test]
        public void RemoveComputer()
        {
            Computer computer = new Computer("Dell", "Vostro", 50);
            computerManager.AddComputer(computer);
            Assert.That(computerManager.RemoveComputer("Dell", "Vostro"), Is.EqualTo(computer));
        }

        [Test]
        public void CannotGetComputerWithNullManufacturer()
        {
            Assert.That(() => computerManager.GetComputer(null, "Vostro"), Throws.ArgumentNullException.With.Message.EqualTo("Can not be null! (Parameter 'manufacturer')"));
        }
        [Test]
        public void CannotGetComputerWithNullModel()
        {
            Assert.That(() => computerManager.GetComputer("Dell", null), Throws.ArgumentNullException.With.Message.EqualTo("Can not be null! (Parameter 'model')"));
        }
        [Test]
        public void GetsComputer()
        {
            Computer computer = new Computer("Dell", "Vostro", 20);
            computerManager.AddComputer(computer);
            Assert.That(computerManager.GetComputer("Dell", "Vostro"), Is.EqualTo(computer));
        }
        [Test]
        public void ThrowsExceptionIfTryToGetNonExistingComputer()
        {
            Assert.That(() => computerManager.GetComputer("Dell", "Vostro"), Throws.ArgumentException.With.Message.EqualTo("There is no computer with this manufacturer and model."));
        }

        [Test]
        public void CannotGetComputersWithNullManufacturer()
        {
            Assert.That(() => computerManager.GetComputersByManufacturer(null), Throws.ArgumentNullException.With.Message.EqualTo("Can not be null! (Parameter 'manufacturer')"));
        }
        [Test]
        public void GetsComputersWithManufacturer()
        {
            computerManager.AddComputer(new Computer("Dell", "Vostro", 20));
            computerManager.AddComputer(new Computer("Dell", "Inspirion", 50));
            computerManager.AddComputer(new Computer("Lenovo", "Legion", 50));
            Assert.That(() => computerManager.GetComputersByManufacturer("Dell").Count, Is.EqualTo(2));
        }

        [Test]
        public void CountReturnsAccurateNumberOfComputers()
        {
            computerManager.AddComputer(new Computer("Dell", "Inspirion", 30));
            computerManager.AddComputer(new Computer("Lenovo", "Legion", 50));
            Assert.That(computerManager.Count, Is.EqualTo(2));
        }

        [Test]
        public void CannotGetNonExistingComputer()
        {
            Assert.That(() => computerManager.GetComputer("Dell", "Vostro"), Throws
                .ArgumentException.With.Message
                .EqualTo("There is no computer with this manufacturer and model."));
        }

        [Test]
        public void CannotRemoveNonExistingComputer()
        {
            Assert.That(() => computerManager.RemoveComputer("Lenovo", "Legion"), Throws
                .ArgumentException.With.Message
                .EqualTo("There is no computer with this manufacturer and model."));
        }

        [Test]
        public void CannotRemoveComputerWithNullManufacturer()
        {
            Assert.That(() => computerManager.RemoveComputer(null, "Legion"), Throws.
                ArgumentNullException.With.Message
                .EqualTo("Can not be null! (Parameter 'manufacturer')"));
        }
        [Test]
        public void CannotRemoveComputerWithNullModel()
        {
            Assert.That(() => computerManager.RemoveComputer("Lenovo", null), Throws.
                ArgumentNullException.With.Message
                .EqualTo("Can not be null! (Parameter 'model')"));
        }

        [Test]
        public void CannotGetComputersByNonExistingManufacturer()
        {
            Assert.That(computerManager.GetComputersByManufacturer("Lenovo").Count, Is.EqualTo(0));
        }
    }
}