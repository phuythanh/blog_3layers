using BlogTest.Service.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogTest.Service.Interfaces
{
    public interface IBlogService
    {
        IEnumerable<BlogDto> GetAll();
        BlogDto CreateOrUpdate(BlogDto model);
        BlogDto GetById(int id);
    }
}
