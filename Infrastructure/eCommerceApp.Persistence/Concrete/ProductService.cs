using eCommerceApp.Application.Abstraction;
using eCommerceApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceApp.Persistence.Concrete
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts()
        => new()
        {
            new() { ID = Guid.NewGuid(),Name = "Product 1", Price = 100,Stock=10},
            new() { ID = Guid.NewGuid(), Name = "Product 2", Price = 200, Stock = 15 },
            new() { ID = Guid.NewGuid(), Name = "Product 3", Price = 300, Stock = 20 },
            new() { ID = Guid.NewGuid(), Name = "Product 4", Price = 400, Stock = 25 }

        };
    }
}
