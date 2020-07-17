using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebAppNLayerBlog.DataAccessLayer.Models;

namespace WebAppNLayerBlog.DataAccessLayer.Data.Seeds
{
    public static class ResourceSeed
    {
        public static void OnResourceSeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Resource>().HasData(
                new Resource[]
                {
                    new Resource { Id = 1, PostId = 1, Name = "blindtextgenerator", Url = "https://www.blindtextgenerator.com/ru" },
                    new Resource { Id = 2, PostId = 2, Name = "loremipsum", Url = "https://loremipsum.io/ru/" }
                });
        }
    }
}
