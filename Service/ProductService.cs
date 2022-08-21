using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mvc.Models;

namespace mvc.Service
{
    public class ProductService : List<Product>
    {
        public ProductService() => this.AddRange(new Product[]{
                new Product(){Id = 1, Name = "IPhone1", Price = 1000},
                new Product(){Id = 2, Name = "IPhone2", Price = 1000},
                new Product(){Id = 3, Name = "IPhone3", Price = 1000},
                new Product(){Id = 4, Name = "IPhone4", Price = 1000},
                new Product(){Id = 5, Name = "IPhone5", Price = 1000}
            });
    }
}