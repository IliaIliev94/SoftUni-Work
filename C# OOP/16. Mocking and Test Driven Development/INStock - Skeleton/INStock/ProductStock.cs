using INStock.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace INStock
{
    public class ProductStock
    {
        private readonly IList<IProduct> products;

        public ProductStock(IList<IProduct> repo)
        {
            products = repo;
        }

        public IProduct this[int index]
        {
            get
            {
                return this.products[index];
            }
            set
            {
                this.products[index] = value;
            }
        }

        public int Count
        {
            get
            {
                return this.products.Count;
            }
        }

        public void Add(IProduct product)
        {
            if(this.products.FirstOrDefault(product => product.Label.Equals(product.Label)) != null)
            {
                throw new InvalidOperationException("Label must be unique.");
            }
            this.products.Add(product);
        }

        public bool Contains(string name)
        {
            IProduct product = this.products.FirstOrDefault(product => product.Label.Equals(name));
            if(product == null)
            {
                return false;
            }
            return true;
        }
    }
}
