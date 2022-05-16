using AutoMapper;
using BlogTest.Data.Entities;
using BlogTest.Service.Dtos;

namespace BlogTest.Service.Mappers
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<BlogDto, BlogEntity>()
                .ReverseMap();
            
        }
    }
}
