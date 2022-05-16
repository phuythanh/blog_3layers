using AutoMapper;
using BlogTest.Data.Entities;
using BlogTest.Data.Interfaces;
using BlogTest.Service.Dtos;
using BlogTest.Service.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace BlogTest.Service.Services
{
    public class BlogService : IBlogService
    {
        private readonly IMapper _mapper;

        private readonly IRepository<BlogEntity> _repository;
        public BlogService(IMapper mapper, IRepository<BlogEntity> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public IEnumerable<BlogDto> GetAll()
        {
            var blogs =_repository.GetAll().ToList();
            return _mapper.Map<List<BlogDto>>(blogs);
        }
    }
}
