using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProductAPI.Models;

//Reference 1: https://www.youtube.com/watch?v=nMGlaiNBbNU&list=PL6n9fhu94yhW7yoUOGNOfHurUE6bpOO2b&index=4
//          2: https://docs.microsoft.com/en-us/aspnet/mvc/overview/getting-started/getting-started-with-ef-using-mvc/creating-an-entity-framework-data-model-for-an-asp-net-mvc-application

namespace ProductAPI.Controllers
{
    public class ProductController : ApiController
    {
        //1. takes a product id and return the product that matches the id
        public IEnumerable<Product> Get(int id){
            using (ProductsDBEntities entities = new ProductsDBEntities())
            {
                yield return entities.Products.FirstOrDefault(p => p.id == id);
            }
            
        }

        //2. return all products
        public IEnumerable<Product> GetAll()
        {
            using (ProductsDBEntities entities = new ProductsDBEntities())
            {
                return entities.Products.ToList();
            }

        }

        //3. edit an item that matches the product id user enters with the product object that is passed in the function
        public string Edit(int id, Product product)
        {
            using (ProductsDBEntities entities = new ProductsDBEntities())
            {
                Product existed = entities.Products.FirstOrDefault(p => p.id == id);
                if (existed != null)
                {
                    entities.Products.FirstOrDefault(p => p.id == id).product_name += ("_eddited");
                    entities.Products.FirstOrDefault(p => p.id == id).price = product.price;
                    entities.Products.FirstOrDefault(p => p.id == id).product_description = product.product_description;
                    entities.SaveChanges();
                    return "Successfully editted item #" + id;
                }
                else
                {
                    return "Could not find item #" + id;
                }
            }
        }
        

        //4. delete an idea that matches the same product id
        public void Delete(int id) 
        {
            using (ProductsDBEntities entities = new ProductsDBEntities())
            {
                entities.Products.Remove(entities.Products.FirstOrDefault(p => p.id == id));
            }
        }

        //5. add a new product to the database
        public void Add(Product product)
        {
            using (ProductsDBEntities entities = new ProductsDBEntities())
            {
                entities.Products.Add(product);
                entities.SaveChanges();
            }
        }

    }
}
