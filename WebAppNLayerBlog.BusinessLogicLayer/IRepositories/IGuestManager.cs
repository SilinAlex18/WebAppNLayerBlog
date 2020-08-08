using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebAppNLayerBlog.BusinessLogicLayer.ViewModels.Guest;

namespace WebAppNLayerBlog.BusinessLogicLayer.IRepositories
{
    public interface IGuestManager
    {
        IEnumerable<PageViewModel> GetGuestIndex();
        GuestDetailViewModel GetGuestDetail(int id);
        IEnumerable<PageViewModel> GetGuestSearch(string searchString);
        PageViewModel GuestPaging(int pageIndex, int pageSize);
    }
}
