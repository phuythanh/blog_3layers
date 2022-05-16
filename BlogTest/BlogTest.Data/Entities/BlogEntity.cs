using System;
using System.ComponentModel.DataAnnotations;

namespace BlogTest.Data.Entities
{
    public class BlogEntity : BaseEntity
    {
        [MaxLength(200)]
        public string Title { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
    }
}
