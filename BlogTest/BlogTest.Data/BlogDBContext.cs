using BlogTest.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlogTest.Data
{
    public class BlogDBContext : DbContext
    {
        public BlogDBContext(DbContextOptions<BlogDBContext> options) : base(options)
        {
        }
        public DbSet<BlogEntity> Blogs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS; Database=QL_NhaMayTramDB; User=sa; Password=Qlk@123456");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
