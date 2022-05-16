using AutoMapper;
using BlogTest.Api.Models;
using BlogTest.Service.Dtos;
using BlogTest.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace BlogTest.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BlogController : ControllerBase
    {
        private readonly IBlogService _blogService;
        private readonly IMapper _mapper;

        private readonly ILogger<BlogController> _logger;

        public BlogController(ILogger<BlogController> logger, IBlogService blogService, IMapper mapper)
        {
            _logger = logger;
            _blogService = blogService;
            _mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<BlogDto> Get()
        {
            return _blogService.GetAll();
        }

        [HttpGet]
        [Route("filter")]
        public IEnumerable<BlogDto> Filter(DateTime from, DateTime to)
        {
            return _blogService.Filter(from, to);
        }

        [HttpPost]
        public BlogDto Post(CreateBlogRequest request)
        {
            var model = _mapper.Map<BlogDto>(request);
            return _blogService.CreateOrUpdate(model);
        }

        [HttpPut]
        [Route("{id:int}")]
        public BlogDto Put(int id, CreateBlogRequest request)
        {
            var bogDetail = _blogService.GetById(id);
            _mapper.Map(request, bogDetail);
            return _blogService.CreateOrUpdate(bogDetail);
        }
    }
}
