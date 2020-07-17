using System;
using System.Collections.Generic;
using System.Text;

namespace WebAppNLayerBlog.DataAccessLayer.Models
{
    public class Media
    {
        public int Id { get; set; }
        public int TypeMediaId { get; set; }
        public int PostId { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public string Url { get; set; }

        public TypeMedia TypeMedia { get; set; }
        public Post Post { get; set; }
    }
}
