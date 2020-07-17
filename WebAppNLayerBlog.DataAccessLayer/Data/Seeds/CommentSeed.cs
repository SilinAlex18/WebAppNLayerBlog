using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebAppNLayerBlog.DataAccessLayer.Models;

namespace WebAppNLayerBlog.DataAccessLayer.Data.Seeds
{
    public static class CommentSeed
    {
        public static void OnCommentSeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comment>().HasData(
                new Comment[]
                {
                    new Comment { Id = 1, PostId = 1, UserId = "773a524b-99af-4fe3-b950-0f7d8ff82b0e", Text = "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", DateTime = DateTime.Now },
                    new Comment { Id = 2, PostId = 2, UserId = "773a524b-99af-4fe3-b950-0f7d8ff82b0e", Text = "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.", DateTime = DateTime.Now }
                });
        }
    }
}
