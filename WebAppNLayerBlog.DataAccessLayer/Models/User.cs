using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebAppNLayerBlog.DataAccessLayer.Models
{
    public class User : IdentityUser
    {
        public List<Comment> Comments { get; set; }
        public List<Bookmark> Bookmarks { get; set; }
    }
}
