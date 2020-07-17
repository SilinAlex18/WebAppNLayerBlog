using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebAppNLayerBlog.DataAccessLayer.Models;

namespace WebAppNLayerBlog.DataAccessLayer.Data.Seeds
{
    public static class MediaSeed
    {
        public static void OnMediaSeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Media>().HasData(
                new Media[]
                {
                    new Media { Id = 1, TypeMediaId = 1, PostId = 1, Name = "youtube", Url = "https://www.youtube.com/watch?v=BggrpKfqh1c" },
                    new Media { Id = 2, TypeMediaId = 2, PostId = 2, Name = "freesound", Url = "https://freesound.org/people/Lorem%20Ipsum/downloaded_sounds/" }
                });
        }
    }
}
