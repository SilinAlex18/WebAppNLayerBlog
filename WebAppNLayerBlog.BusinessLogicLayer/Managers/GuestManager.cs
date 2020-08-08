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
    public class GuestManager : IGuestManager
    {
        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _context;

        public GuestManager(IMapper mapper, ApplicationDbContext context)
        {
            _context = context;
            _mapper = mapper;
        }

        public IEnumerable<PageViewModel> GetGuestIndex()
        {
            var posts = _context.Posts.Include(u => u.Category).ToList();
            return _mapper.Map<List<PageViewModel>>(posts);
        }

        public GuestDetailViewModel GetGuestDetail(int id)
        {
            var post = _context.Posts.Include(u => u.Category)
                .Include(u => u.Comments).ThenInclude(u => u.User).FirstOrDefault(u => u.Id == id);
            return _mapper.Map<GuestDetailViewModel>(post);
        }

        public IEnumerable<PageViewModel> GetGuestSearch(string searchString)
        {
            var posts = _context.Posts.Include(u => u.Category)
                .Where(s => s.Title.Contains(searchString) || s.Subtitle.Contains(searchString)).ToList();
            return _mapper.Map<List<PageViewModel>>(posts);
        }

        public PageViewModel GuestPaging(int pageIndex, int pageSize)
        {
            var posts = _context.Posts.Include(u => u.Category).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();

            var viewModel = new PageViewModel();
            viewModel.PostViewModels = _mapper.Map<List<PostViewModel>>(posts);
            viewModel.PageIndex = pageIndex;
            int totalPages = (int)Math.Ceiling(_context.Posts.Count() / (double)pageSize);
            viewModel.TotalPages = totalPages;
            viewModel.HasPreviousPage = pageIndex > 1;
            viewModel.HasNextPage = pageIndex < totalPages;

            return viewModel;
        }
    }
}
