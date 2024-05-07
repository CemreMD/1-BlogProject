using _1_BlogProject.Core.DomailModels.Models;
using _2_BlogProject.Application.DTO_s;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BlogProject.Application.Mappers
{
    public class Mapping : Profile
    {
        protected Mapping()
        {
            CreateMap<AppUser, AppUserDTO>().ForMember(dest => dest.FullName, opt => opt.MapFrom(src=>src.Firstname+" "+src.LastName));
            CreateMap<Article,ArticleDTO>().ReverseMap();
            CreateMap<Category,CategoryDTO>().ReverseMap();
            CreateMap<Comment,CommentDTO>().ReverseMap();
        }
    }
}
