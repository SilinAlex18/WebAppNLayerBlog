using System;
using System.Collections.Generic;
using System.Text;
using WebAppNLayerBlog.BusinessLogicLayer.ViewModels.Guest;

namespace WebAppNLayerBlog.BusinessLogicLayer.IRepositories
{
    public interface IGuestRepository
    {
        IEnumerable<GuestIndexViewModel> GetGuestIndex();
        GuestDetailViewModel GetGuestDetail(int id);
    }
}
