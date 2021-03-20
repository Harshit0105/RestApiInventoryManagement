using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestApiInventoryManagement.model;

namespace RestApiInventoryManagement.Data
{
    public interface IProductRepo
    {
        public void addProduct(Product product  );
        public bool deleteProduct(int id);
        public void updateProduct(Product product);
        public IEnumerable<Product> getAllProducts();
        public Product getProduct(int id);
    }
}
