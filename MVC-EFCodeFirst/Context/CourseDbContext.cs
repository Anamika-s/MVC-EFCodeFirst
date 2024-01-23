using Microsoft.EntityFrameworkCore;
using MVC_EFCodeFirst.Models;

namespace MVC_EFCodeFirst.Context
{
    public class CourseDbContext : DbContext
    {
        public CourseDbContext(DbContextOptions<CourseDbContext> options) :
            base(options)
        { }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Batch> Batches { get; set; }

    }
}
