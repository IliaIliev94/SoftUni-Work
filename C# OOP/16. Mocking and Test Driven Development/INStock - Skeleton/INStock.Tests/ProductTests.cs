namespace INStock.Tests
{
    using INStock.Contracts;
    using INStock;
    using Moq;
    using NUnit.Framework;
    using System.Collections.Generic;

    [TestFixture]
    public class ProductTests
    {
        private List<IProduct> repo;
        private Mock<IProduct> mockProduct;
        private ProductStock stock;
        [SetUp]
        public void Initialize()
        {
            repo = new List<IProduct>();
            mockProduct = new Mock<IProduct>();
            mockProduct.Setup(p => p.Label).Returns("Beer");
            mockProduct.Setup(p => p.Price).Returns(20);
            stock = new ProductStock(repo);
        }
        [Test]
        public void ProductMustBeInSystemAfterAdd()
        {

            stock.Add(mockProduct.Object);
            Assert.That(stock[0].Label, Is.EqualTo("Beer"));
        }
        [Test]
        public void SystemMustContainProduct()
        {
            stock.Add(mockProduct.Object);

            Assert.That(stock.Contains("Beer"), Is.EqualTo(true));
        }

        [Test]
        public void SystemMustCountProducts()
        {
            repo.Add(mockProduct.Object);
            int count = stock.Count;
            Assert.That(count, Is.EqualTo(1));
        }

        [Test]
        public void LabelMustBeUnique()
        {
            Mock<IProduct> mockProduct2 = new Mock<IProduct>();
            mockProduct2.Setup(product => product.Label).Returns("Beer");
            mockProduct2.Setup(product => product.Price).Returns(10);
            stock.Add(mockProduct.Object);
            

            Assert.That(() => stock.Add(mockProduct2.Object), Throws
                .InvalidOperationException.With.Message
                .EqualTo("Label must be unique."));
        }

        [Test]
        public void SystemMustFindProduct()
        {

        }
    }
}