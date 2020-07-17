using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebAppNLayerBlog.DataAccessLayer.Models;

namespace WebAppNLayerBlog.DataAccessLayer.Data.Seeds
{
    public static class PostSeed
    {
        public static void OnPostSeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>().HasData(
                new Post[]
                {
                    new Post { Id = 1, CategoryId = 1, Title = "Lorem ipsum dolor sit amet", Subtitle = "Aenean massa", Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit.", DateTime = DateTime.Now },
                    new Post { Id = 2, CategoryId = 2, Title = "Cum sociis natoque penatibus et magnis dis parturient montes", Subtitle = "Donec quam felis", Description = "Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.", DateTime = DateTime.Now }
                });
        }
    }
}
