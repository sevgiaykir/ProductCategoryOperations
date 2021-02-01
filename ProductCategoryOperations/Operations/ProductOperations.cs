using Microsoft.EntityFrameworkCore;
using ProductCategoryOperations.Data;
using ProductCategoryOperations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCategoryOperations.Operations
{
    class ProductOperations
    {
        ProductCategoryDB db = new ProductCategoryDB();

        public int AddProduct(Product product)
        {
            db.Products.Add(product);
            return db.SaveChanges();
        }

        public Category GetCategoryById(int id)
        {
            return db.Categories.Find(id);
        }

        public Product GetProductById(int id)
        {
            return db.Products.Find(id);
        }

        public int UpdateProduct(Product product)
        {
            db.Entry(product).State = EntityState.Modified;
            return db.SaveChanges();
        }

        public int DeleteProduct(Product product)
        {
            db.Products.Remove(product);
            return db.SaveChanges();
        }
    }
}
