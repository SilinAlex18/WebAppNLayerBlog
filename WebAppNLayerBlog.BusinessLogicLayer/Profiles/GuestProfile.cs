using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using WebAppNLayerBlog.BusinessLogicLayer.ViewModels.Guest;
using WebAppNLayerBlog.DataAccessLayer.Models;

namespace WebAppNLayerBlog.BusinessLogicLayer.Profiles
{
    public class GuestProfile : Profile
    {
        public GuestProfile()
        {
            CreateMap<Post, GuestIndexViewModel>();
            CreateMap<Post, GuestDetailViewModel>();
        }
    }
}
