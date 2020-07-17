using System;
using System.Collections.Generic;
using System.Text;

namespace WebAppNLayerBlog.DataAccessLayer.Models
{
    public class TypeMedia
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Media> Medias { get; set; }
    }
}
