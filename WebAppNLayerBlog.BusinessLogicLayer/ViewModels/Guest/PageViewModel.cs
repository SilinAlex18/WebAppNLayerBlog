using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebAppNLayerBlog.DataAccessLayer.Models;

namespace WebAppNLayerBlog.BusinessLogicLayer.ViewModels.Guest
{
    public class PageViewModel
    {
        public int PageIndex { get; set; }
        public int TotalPages { get; set; }
        public bool HasPreviousPage { get; set; }
        public bool HasNextPage { get; set; }
        public List<PostViewModel> PostViewModels { get; set; }
    }
}
