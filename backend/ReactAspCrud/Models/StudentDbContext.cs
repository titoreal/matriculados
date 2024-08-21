using Microsoft.EntityFrameworkCore;

namespace ReactAspCrud.Models
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=REALENOVO;Initial Catalog=lbs;Integrated Security=True;TrustServerCertificate=True;");
        }
    }
}
