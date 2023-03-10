using DataAccessLayer.Model;
using Microsoft.EntityFrameworkCore;

namespace asingment.Model
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

       public DbSet<Student> Students { get; set; }
       public DbSet<Course> Courses { get; set; }
    }
}
