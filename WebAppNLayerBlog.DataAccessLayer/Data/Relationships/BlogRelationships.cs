using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebAppNLayerBlog.DataAccessLayer.Models;

namespace WebAppNLayerBlog.DataAccessLayer.Data.Relationships
{
    public static class BlogRelationships
    {
        public static void OnBlogRelationship(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bookmark>(entity =>
            {
                entity.HasOne(d => d.Post)
                    .WithMany(p => p.Bookmarks)
                    .HasForeignKey(d => d.PostId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Bookmarks)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.HasOne(d => d.Post)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.PostId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<Media>(entity =>
            {
                entity.HasOne(d => d.Post)
                    .WithMany(p => p.Medias)
                    .HasForeignKey(d => d.PostId);

                entity.HasOne(d => d.TypeMedia)
                    .WithMany(p => p.Medias)
                    .HasForeignKey(d => d.TypeMediaId);
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Posts)
                    .HasForeignKey(d => d.CategoryId);
            });

            modelBuilder.Entity<Resource>(entity =>
            {
                entity.HasOne(d => d.Post)
                    .WithMany(p => p.Resources)
                    .HasForeignKey(d => d.PostId);
            });
        }
    }
}
