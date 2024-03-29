﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using more namespaces for Entity Framework Core
using System.IO;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;

namespace ManageCategoriesApp
{
    public class MyStockDBContext
    {
        //Declare Category Entity
        public class Category { 
            public Category() { }
            [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int CategoryID { get; set; }
            public string CategoryName { get; set; }
        }//end Category
        public class MyStock : DbContext
        {
            public MyStock() { }
            //These properties map to tables in the database
            public DbSet<Category> Categories { get; set; }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                var builder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                IConfigurationRoot config = builder.Build();
                optionsBuilder.UseSqlServer(config.GetConnectionString("MyStockDB"));
            }
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                //Using Fluent API instead of attributes
                //to limit the length of CategoryName to under 40
                modelBuilder.Entity<Category>()
                    .Property(Category => Category.CategoryName)
                    .IsRequired()//Not Null
                    .HasMaxLength(40);
                //Insert data for Categories table
                modelBuilder.Entity<Category>().HasData(
                    new Category { CategoryID = 1, CategoryName = "Beverages" },
                    new Category { CategoryID = 2, CategoryName = "Condiments" },
                    new Category { CategoryID = 3, CategoryName = "Confections" }
                    );
            }
        }//end MyStock
    }
}
