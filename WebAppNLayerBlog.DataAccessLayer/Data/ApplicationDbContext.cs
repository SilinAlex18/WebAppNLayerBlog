using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebAppNLayerBlog.DataAccessLayer.Data.Relationships;
using WebAppNLayerBlog.DataAccessLayer.Data.Seeds;
using WebAppNLayerBlog.DataAccessLayer.Models;

namespace WebAppNLayerBlog.DataAccessLayer.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<TypeMedia> TypeMedias { get; set; }
        public DbSet<Media> Medias { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Bookmark> Bookmarks { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
               : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("server=localhost;database=blog;user=root;password=root");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.OnIdentityRelationship();
            modelBuilder.OnBlogRelationship();

            modelBuilder.OnCategorySeed();
            modelBuilder.OnPostSeed();
            modelBuilder.OnResourceSeed();
            modelBuilder.OnTypeMediaSeed();
            modelBuilder.OnMediaSeed();
            modelBuilder.OnUserSeed();
            modelBuilder.OnCommentSeed();
            modelBuilder.OnBookmarkSeed();
        }
    }
}
