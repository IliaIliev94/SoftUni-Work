namespace Computers.Tests
{
    using NUnit.Framework;

    public class ComputerTests
    {
        private Part part;
        private Part secondPart;
        private Computer computer;
        [SetUp]
        public void Setup()
        {
            part = new Part("Chast", 200);
            secondPart = new Part("Nova Chast", 400);
            computer = new Computer("Komp");
        }

        [Test]
        public void ComputerInitializesProperly()
        {
            Assert.AreEqual(computer.Parts.Count, 0);
            Assert.AreEqual(computer.TotalPrice, 0);
        }

        [Test]
        public void NamePropertyInitializesProperly()
        {
            Assert.AreEqual(computer.Name, "Komp");
        }

        [Test]
        public void NameThrowsErrorIfItIsWhitespaceOrNull()
        {
            Assert.That(() => computer = new Computer(null), Throws.
                ArgumentNullException.With.Message.EqualTo("Name cannot be null or empty! (Parameter 'Name')"));
            Assert.That(() => computer = new Computer(""), Throws.
                ArgumentNullException.With.Message.EqualTo("Name cannot be null or empty! (Parameter 'Name')"));
            Assert.That(() => computer = new Computer(" "), Throws.
                ArgumentNullException.With.Message.EqualTo("Name cannot be null or empty! (Parameter 'Name')"));
        }

        [Test]
        public void AddsComputerPart()
        {
            computer.AddPart(part);
            Assert.AreEqual(computer.Parts.Count, 1);
            computer.AddPart(secondPart);
            Assert.AreEqual(computer.Parts.Count, 2);
        }

        [Test]
        public void ThrowsErrorIfTryToAddNullPart()
        {
            Assert.That(() => computer.AddPart(null), Throws.
               InvalidOperationException.With.Message.EqualTo("Cannot add null!"));
        }

        [Test]
        public void TotalSUmReturnsAccurateNumber()
        {
            computer.AddPart(part);
            Assert.AreEqual(computer.TotalPrice, 200);
            computer.AddPart(secondPart);
            Assert.AreEqual(computer.TotalPrice, 600);
        }

        [Test]
        public void RemovePart()
        {
            computer.AddPart(part);
            computer.AddPart(secondPart);
            Assert.AreEqual(computer.Parts.Count, 2);
            Assert.AreEqual(computer.TotalPrice, 600);
            computer.RemovePart(secondPart);
            Assert.AreEqual(computer.Parts.Count, 1);
            Assert.AreEqual(computer.TotalPrice, 200);
        }

        [Test]
        public void GetsPart()
        {
            computer.AddPart(part);
            computer.AddPart(secondPart);
            Assert.AreEqual(computer.GetPart("Chast"), part);
            Assert.AreEqual(computer.GetPart("Nova Chast"), secondPart);
        }
    }
}