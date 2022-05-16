using System;

namespace BlogTest.Service.Dtos
{
    public class BaseDto
    {
        public int Id { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
