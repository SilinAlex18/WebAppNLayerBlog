using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebAppNLayerBlog.BusinessLogicLayer.IRepositories;
using WebAppNLayerBlog.BusinessLogicLayer.ViewModels.Guest;
using WebAppNLayerBlog.DataAccessLayer.Data;

namespace WebAppNLayerBlog.BusinessLogicLayer.Managers
{
    public class GuestManager : IGuestRepository
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

        public IEnumerable<GuestIndexViewModel> GetGuestSearch(string searchString)
        {
            var model = _context.Posts.Include(u => u.Category)
                .Where(s => s.Title.Contains(searchString) || s.Subtitle.Contains(searchString)).ToList();
            return _mapper.Map<List<GuestIndexViewModel>>(model);
        }

        public PageViewModel<GuestIndexViewModel> GuestPaging(IQueryable<GuestIndexViewModel> source, int pageIndex, int pageSize)
        {
            var count = source.Count();
            var items = source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            return new PageViewModel<GuestIndexViewModel>(items, count, pageIndex, pageSize);
        }
    }
}
