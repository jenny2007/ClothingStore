using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JW.ClothingStore.Domain.Abstract;
using JW.ClothingStore.Domain.Entities;

namespace JW.ClothingStore.Domain.Concrete
{
    public class InMemoryProductsRepository : IProductsRepository
    {
        private List<Product> _products = new List<Product>
        {
            new Product { Name = "Midi Dress", Price = 125 },
            new Product { Name = "Winter Jacket", Price = 150 },
            new Product { Name = "Pants", Price = 80 },
            new Product { Name = "Shirt", Price = 60 },
            new Product { Name = "T-Shirt", Price = 50 }
        };
        public IEnumerable<Product> Products
        {
            get 
            { 
                return _products;
            }
        }
    }
}
