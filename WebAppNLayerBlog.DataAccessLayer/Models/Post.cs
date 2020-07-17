using System;
using System.Collections.Generic;
using System.Text;

namespace WebAppNLayerBlog.DataAccessLayer.Models
{
    public class Post
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Description { get; set; }
        public DateTime DateTime { get; set; }

        public List<Media> Medias { get; set; }
        public Category Category { get; set; }
        public List<Resource> Resources { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Bookmark> Bookmarks { get; set; }
    }
}
