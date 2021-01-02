using NUnit.Framework;

namespace Store.Tests
{
    public class StoreManagerTests
    {
        private StoreManager storeManager;
        [SetUp]
        public void Setup()
        {
            storeManager = new StoreManager();
        }

        [Test]
        public void CantAddNullProduct()
        {
            Product product = null;
            Assert.That(() => storeManager.AddProduct(product), Throws.ArgumentNullException.With.Message.EqualTo("Value cannot be null. (Parameter 'product')"));
        }
        [Test]
        public void CantAddProductWithNegativeQuantity()
        {
            Assert.That(() => storeManager.AddProduct(new Product("P", -1, 20)), Throws.ArgumentException.With.Message.EqualTo("Product count can't be below or equal to zero."));
        }
        [Test]
        public void AddsProduct()
        {
            storeManager.AddProduct(new Product("P", 1, 5));
            Assert.That(storeManager.Products.Count, Is.EqualTo(1));
        }

        [Test]
        public void CantBuyNonExistingProduct()
        {
            Assert.That(() => storeManager.BuyProduct("Nishto", 1), Throws.ArgumentNullException.With.Message.EqualTo("There is no such product. (Parameter 'product')"));
        }

        [Test]
        public void CantBuyMoreQuantityThanProductHas()
        {
            storeManager.AddProduct(new Product("Nishto", 1, 50));
            Assert.That(() => storeManager.BuyProduct("Nishto", 2), Throws.ArgumentException.With.Message.EqualTo("There is not enough quantity of this product."));
        }
        [Test]
        public void ReducesBoughtQuantity()
        {
            Product product = new Product("Nishto", 2, 50);
            storeManager.AddProduct(product);
            storeManager.BuyProduct("Nishto", 1);
            Assert.That(product.Quantity, Is.EqualTo(1));
        }
        [Test]
        public void ReturnsCorrectPrice()
        {
            storeManager.AddProduct(new Product("Nishto", 2, 50));
            Assert.That(storeManager.BuyProduct("Nishto", 1), Is.EqualTo(50));
        }
        [Test]
        public void BuysMostExpensiveProduct()
        {
            Product product = new Product("Nishto", 2, 50);
            Product product1 = new Product("Neshto", 1, 100);
            storeManager.AddProduct(product);
            storeManager.AddProduct(product1);
            Assert.That(storeManager.GetTheMostExpensiveProduct(), Is.EqualTo(product1));
        }

        [Test]
        public void CountReturnsCorrectQuantityOfProducts()
        {
            Product product = new Product("Nishto", 2, 50);
            Product product1 = new Product("Neshto", 1, 100);
            storeManager.AddProduct(product);
            storeManager.AddProduct(product);
            Assert.That(storeManager.Count, Is.EqualTo(2));
        }
    }
}