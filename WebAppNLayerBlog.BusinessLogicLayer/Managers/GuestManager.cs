using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebAppNLayerBlog.BusinessLogicLayer.ViewModels.Guest;
using WebAppNLayerBlog.DataAccessLayer.Data;

namespace WebAppNLayerBlog.BusinessLogicLayer.Managers
{
    public class GuestManager
    {
        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _context;

        public GuestManager(IMapper mapper, ApplicationDbContext context)
        {
            _context = context;
            _mapper = mapper;
        }

        public IEnumerable<GuestIndexViewModel> GetGuestIndex()
        {
            var model = _context.Posts.Include(u => u.Category).ToList();
            return _mapper.Map<List<GuestIndexViewModel>>(model);
        }

        public GuestDetailViewModel GetGuestDetail(int id)
        {
            var model = _context.Posts.Include(u => u.Category)
                .Include(u => u.Comments).ThenInclude(u => u.User).FirstOrDefault(u => u.Id == id);
            return _mapper.Map<GuestDetailViewModel>(model);
        }
    }
}
