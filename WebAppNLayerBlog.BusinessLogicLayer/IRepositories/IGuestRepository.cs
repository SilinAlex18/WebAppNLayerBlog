using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebAppNLayerBlog.BusinessLogicLayer.ViewModels.Guest;

namespace WebAppNLayerBlog.BusinessLogicLayer.IRepositories
{
    public interface IGuestRepository
    {
        IEnumerable<GuestIndexViewModel> GetGuestIndex();
        GuestDetailViewModel GetGuestDetail(int id);
        IEnumerable<GuestIndexViewModel> GetGuestSearch(string searchString);
        PageViewModel<GuestIndexViewModel> GuestPaging(IQueryable<GuestIndexViewModel> source, int pageIndex, int pageSize);
    }
}
