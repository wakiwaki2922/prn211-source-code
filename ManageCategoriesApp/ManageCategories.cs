﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ManageCategoriesApp.MyStockDBContext;

namespace ManageCategoriesApp
{
    public sealed class ManageCategories
    {
        private static ManageCategories instance = null;
        private static readonly object instanceLock = new object();

        private ManageCategories() { }

        public static ManageCategories Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ManageCategories();
                    }
                    return instance;
                }
            }

        }

        public List<Category> GetCategories()
        {
            List<Category> categories;
            try
            {
                using MyStock stock = new MyStock();
                categories = stock.Categories.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return categories;
        }

        public void InsertCategory(Category category)
        {
            try
            {
                using MyStock stock = new MyStock();
                stock.Categories.Add(category);
                stock.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateCategory(Category category)
        {
            try
            {
                using MyStock stock = new MyStock();
                stock.Entry<Category>(category).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                stock.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteCategory(Category category)
        {
            try
            {
                using MyStock stock = new MyStock();
                var cate = stock.Categories.SingleOrDefault(c => c.CategoryID == category.CategoryID);
                stock.Categories.Remove(cate);
                stock.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

