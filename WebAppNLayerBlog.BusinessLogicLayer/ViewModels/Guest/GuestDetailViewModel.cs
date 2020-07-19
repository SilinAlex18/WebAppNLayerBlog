using System;
using System.Collections.Generic;
using System.Text;
using WebAppNLayerBlog.DataAccessLayer.Models;

namespace WebAppNLayerBlog.BusinessLogicLayer.ViewModels.Guest
{
    public class GuestDetailViewModel
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Description { get; set; }
        public DateTime DateTime { get; set; }

        public Category Category { get; set; }
        public IEnumerable<Comment> Comments { get; set; }
    }
}
