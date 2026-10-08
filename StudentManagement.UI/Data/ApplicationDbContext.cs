using Microsoft.EntityFrameworkCore;
using StudentManagement.UI.Models;

namespace StudentManagement.UI.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
  
    }
}
