using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebAppNLayerBlog.DataAccessLayer.Models;

namespace WebAppNLayerBlog.DataAccessLayer.Data.Seeds
{
    public static class CategorySeed
    {
        public static void OnCategorySeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category[]
                {
                    new Category { Id = 1, Name = "IT" },
                    new Category { Id = 2, Name = "Travel" }
                });
        }
    }
}
