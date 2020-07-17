using System;
using System.Collections.Generic;
using System.Text;

namespace WebAppNLayerBlog.DataAccessLayer.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public string UserId { get; set; }
        public string Text { get; set; }
        public DateTime DateTime { get; set; }

        public Post Post { get; set; }
        public User User { get; set; }
    }
}
