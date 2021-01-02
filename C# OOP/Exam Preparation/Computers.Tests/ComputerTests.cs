namespace Computers.Tests
{
    using NUnit.Framework;

    public class ComputerTests
    {
        private Computer computer;
        [SetUp]
        public void Setup()
        {
            computer = new Computer("Moq Komp");
        }

        [Test]
        public void ComputerNameCannotBeNull()
        {
            Assert.That(() => computer = new Computer(null), Throws.ArgumentNullException.With.Message.EqualTo("Name cannot be null or empty! (Parameter 'Name')"));
        }
        [Test]
        public void TotalPriceIsCorrect()
        {
            computer.AddPart(new Part("Procesor", 20));
            computer.AddPart(new Part("RAM", 30));
            Assert.AreEqual(50, computer.TotalPrice);
        }

        [Test]
        public void CannotAddNullPart()
        {
            Assert.That(() => computer.AddPart(null), Throws.InvalidOperationException.With.Message.EqualTo("Cannot add null!"));
        }

        [Test]
        public void AddsPart()
        {
            Part part = new Part("Chast", 50);
            computer.AddPart(part);
            Assert.That(computer.Parts.Count, Is.EqualTo(1));
        }
        [Test]
        public void RemovesPart()
        {
            Part part = new Part("Chast", 50);
            computer.AddPart(part);
            computer.RemovePart(part);
            Assert.That(computer.Parts.Count, Is.EqualTo(0));
        }
        [Test]
        public void GetsExistingPart()
        {
            Part part = new Part("Chast", 50);
            computer.AddPart(part);
            Assert.That(computer.GetPart("Chast"), Is.EqualTo(part));
        }
    }
}