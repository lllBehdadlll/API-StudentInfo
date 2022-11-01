using Microsoft.EntityFrameworkCore;
using StudentInfo.Mappings;
using StudentInfo.Models;

namespace StudentInfo
{
    public class StudentContext: DbContext
    {
        public DbSet<Student> Students{ get; set; }

        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
