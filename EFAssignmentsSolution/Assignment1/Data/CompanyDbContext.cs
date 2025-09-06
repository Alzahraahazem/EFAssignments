
using Assignment1.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Assignment1.Data
{
    internal class ITIyDbContext: DbContext
    {
        public ITIyDbContext() : base()
        {

        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
              optionsBuilder.UseSqlServer("Server=DESKTOP-JEJ8BBV\\SQLEXPRESS; Database= ITI ;Trusted_Connection=True ; TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.ApplyConfiguration(new TopicConfigurations());

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<Course_Inst>()
                .HasKey(ci => new { ci.InstructorId, ci.CourseId });

            modelBuilder.Entity<Stud_Course>()
              .HasKey(sc => new { sc.StudentId, sc.CourseId });
        }



        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course_Inst> Course_Insts { get; set; }
        public DbSet<Stud_Course> Stud_Courses { get; set; }
        public DbSet<Topic> Topics { get; set; }



    }
}
