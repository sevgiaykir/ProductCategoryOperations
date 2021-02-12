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
    public class CategoryOperations
    {
        ProductCategoryDB db = new ProductCategoryDB();

        //Crud operations for categories
        public List<Category> GetCategories()
        {
            return db.Categories.ToList();
        }

        public int AddCategory(Category category)
        {
            db.Categories.Add(category);
            return db.SaveChanges();
        }

        public Category GetCategoriesById(int id)
        {
            return db.Categories.Find(id);
        }

        public int DeleteCategory(Category categories)
        {
            db.Categories.Remove(categories);
            return db.SaveChanges();
        }

        public int UpdateCategory(Category category)
        {
            db.Entry(category).State = EntityState.Modified;
            return db.SaveChanges();
        }
    }
}
