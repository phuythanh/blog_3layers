using AutoMapper;
using BlogTest.Service.Dtos;
using BlogTest.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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
    }
}
