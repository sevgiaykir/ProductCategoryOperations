using Microsoft.EntityFrameworkCore;
using ProductCategoryOperations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCategoryOperations.Data
{
    public class ProductCategoryDB: DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        //model oluşturulurken kullanılacak metottur, tablolar arası ilişkide denetleme yapar
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(category => category.Products)
                .WithOne(prod => prod.Category)
                .HasForeignKey(pr => pr.CategoryId);

            /*ya da 
            modelBuilder.Entity<Product>()
            .HasOne(p => p.Category)
            .WithMany(c => c.Products)
            .HasForeignKey(p => p.CategoryId);
            */
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //connection string
                optionsBuilder.UseSqlServer("Server= .\\SevgiDev; Database=ProductCategoryDb; Integrated Security=yes");
            }
        }
    }
}
