using AutoMapper;

using SocialMedia.Core.DTOs;
using SocialMedia.Core.Entities;

namespace SocialMedia.Infrastructure.Mappings
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Post, PostDTO>();
            CreateMap<PostDTO, Post>();

            CreateMap<Security, SecurityDTO>().ReverseMap();
        }
    }
}