using AutoMapper;
using BlogTest.Api.Models;
using BlogTest.Service.Dtos;

namespace BlogTest.Api.Mappers
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<CreateBlogRequest, BlogDto>();

        }
    }
}
