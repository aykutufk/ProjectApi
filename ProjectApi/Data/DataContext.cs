using Microsoft.EntityFrameworkCore;
using ProjectApi.Models;

namespace ProjectApi.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext>options):base(options) { } 
        public DbSet<AdminModel> Admin { get; set; }
        public DbSet<CategoryModel> Category { get; set; }
        public DbSet<CommentModel> Comment { get; set; }
        public DbSet<PostModel> Posts { get; set; }
        public DbSet<BlogModel> Blog { get; set; }

    }
}
