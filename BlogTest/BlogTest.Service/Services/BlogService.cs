using AutoMapper;
using BlogTest.Data.Entities;
using BlogTest.Data.Interfaces;
using BlogTest.Service.Dtos;
using BlogTest.Service.Interfaces;
using System;
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

        public BlogDto CreateOrUpdate(BlogDto model)
        {
            var entity = _mapper.Map<BlogEntity>(model);
            if (entity.Id == 0)
            {
                _repository.Insert(entity);
            }
            else
            {
                _repository.Update(entity);
            }
            return _mapper.Map<BlogDto>(entity);
        }

        public IEnumerable<BlogDto> Filter(DateTime from, DateTime to)
        {
            var blogs = _repository.Find(x => from <= x.CreatedDate && x.CreatedDate <= to).ToList();
            return _mapper.Map<List<BlogDto>>(blogs);
        }

        public IEnumerable<BlogDto> GetAll()
        {
            var blogs = _repository.GetAll().ToList();
            return _mapper.Map<List<BlogDto>>(blogs);
        }

        public BlogDto GetById(int id)
        {
            var blog = _repository.GetById(id);
            return _mapper.Map<BlogDto>(blog);
        }
    }
}
