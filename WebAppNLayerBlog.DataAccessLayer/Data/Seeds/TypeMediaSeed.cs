using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebAppNLayerBlog.DataAccessLayer.Models;

namespace WebAppNLayerBlog.DataAccessLayer.Data.Seeds
{
    public static class TypeMediaSeed
    {
        public static void OnTypeMediaSeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TypeMedia>().HasData(
                new TypeMedia[]
                {
                    new TypeMedia { Id = 1, Name = "video" },
                    new TypeMedia { Id = 2, Name = "audio" }
                });
        }
    }
}
