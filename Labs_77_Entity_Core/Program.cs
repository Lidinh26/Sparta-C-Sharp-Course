﻿using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Labs_77_Entity_Core
{
    class Program
    {
        static List<Category> categories;
        static List<Product> products;

        static void Main(string[] args)
        {
            using (var db = new Northwind())
            {
                categories = db.Categories.ToList();
                products = db.Products.ToList();

                foreach (var p in products)
                {
                    var category = db.Categories.Find(p.CategoryID);
                    Console.WriteLine($"{p.ProductID,-15} {p.ProductName,-40}{p.CategoryID, -10}{p.Category.CategoryName}");
                }
            }
        }
    }

    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        [Column(TypeName = "ntext")]
        public string Description { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public Category()
        {
            this.Products = new List<Product>();
        }
    }
    public class Product
    {
        public int ProductID { get; set; }
        [Required]
        [StringLength(40)]
        public string ProductName { get; set; }
        [Column("UnitPrice", TypeName = "money")]
        public decimal? Cost { get; set; }
        [Column("UnitsInStock")]
        public short? Stock { get; set; }
        public bool Discontinued { get; set; }
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }



    public class Northwind : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string path = System.IO.Path.Combine(System.Environment.CurrentDirectory, "../data/Northwind.db");
            // use SQLite
            optionsBuilder.UseSqlite($"Filename={$"C:/Data/Northwind.db"}");
            // use SQL
            //optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;" + "Initial Catalog=Northwind;" + "Integrated Security=true;" + "MultipleActiveResultSets=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .Property(category => category.CategoryName)
                .IsRequired()
                .HasMaxLength(40);
            // filter out discontinued products
            modelBuilder.Entity<Product>()
                .HasQueryFilter(p => !p.Discontinued);
        }

    }
}
