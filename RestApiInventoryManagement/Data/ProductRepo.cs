using RestApiInventoryManagement.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiInventoryManagement.Data
{
    public class ProductRepo : IProductRepo
    {
        private readonly InventoryAppContext context;

        public ProductRepo(InventoryAppContext context)
        {
            this.context = context;
        }
        public void addProduct(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
            return;
            //throw new NotImplementedException();
        }

        public bool deleteProduct(int id)
        {
            var deleteItm =  context.Products.Find(id);
            if(deleteItm == null)
            {
                return false;
            }
            else
            {
                context.Products.Remove(deleteItm);
                context.SaveChanges();
                return true;
            }

           // throw new NotImplementedException();
        }

        public IEnumerable<Product> getAllProducts()
        {
            return context.Products;
            //throw new NotImplementedException();
        }

        public Product getProduct(int id)
        {
            var prod = context.Products.Find(id);
            if(prod == null)
            {
                return null; 
            }
            else
            {
                return prod;
            }
            //throw new NotImplementedException();
        }

        public void updateProduct(Product product)
        {
            var t = context.Products.Attach(product);
            t.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return ;
            //throw new NotImplementedException();
        }
    }
}
