using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestApiInventoryManagement.Data;
using RestApiInventoryManagement.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiInventoryManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepo repo;
        public ProductController(IProductRepo repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Product>> getAllProducts() {
            var temp = repo.getAllProducts();
            return Ok(temp);

        }

        [HttpGet("{id}")] 
        public ActionResult<Product> getProduct(int id)
        {
            var temp = repo.getProduct(id);
            return Ok(temp);           

        }

        [HttpPost]
        public ActionResult addProduct(Product product)
        {
            Product temp = new Product();
            temp.brand = product.brand;
            temp.checkedBy = product.checkedBy;
            temp.dateOfArrival = product.dateOfArrival;
            temp.name = product.name;
            temp.price = product.price;
            temp.quantity = product.quantity;
            repo.addProduct(temp);
            return Ok();
        }
        [HttpDelete("{id}")]
        
        public ActionResult deleteProduct(int id)
        {
            var temp = repo.deleteProduct(id);
            if(temp == false)
            {
                return NotFound();
            }
            else
            {
                return Ok();
            }
            

        }

        [HttpPut("{id}")]
        public ActionResult updateProduct(int id, Product product)
        {
            Product temp = repo.getProduct(id);
            temp.brand = product.brand;
            temp.checkedBy = product.checkedBy;
            temp.dateOfArrival = product.dateOfArrival;
            temp.name = product.name;
            temp.price = product.price;
            temp.quantity = product.quantity;
            temp.productId = product.productId;
            repo.updateProduct(temp);

            return Ok();
        }

    }
}
