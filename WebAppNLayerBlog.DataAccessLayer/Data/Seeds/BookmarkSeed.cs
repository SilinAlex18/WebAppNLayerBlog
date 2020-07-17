using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebAppNLayerBlog.DataAccessLayer.Models;

namespace WebAppNLayerBlog.DataAccessLayer.Data.Seeds
{
    public static class BookmarkSeed
    {
        public static void OnBookmarkSeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bookmark>().HasData(
                new Bookmark[]
                {
                    new Bookmark { Id = 1, PostId = 1, UserId = "773a524b-99af-4fe3-b950-0f7d8ff82b0e" },
                    new Bookmark { Id = 2, PostId = 2, UserId = "773a524b-99af-4fe3-b950-0f7d8ff82b0e" }
                });
        }
    }
}
