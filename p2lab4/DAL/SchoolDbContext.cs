using DAL.Models;
using System.Data.Entity;

namespace DAL
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext()
            : base("data source=LAPTOP-PJ2N04JC;initial catalog=p2lab4;user id=sa;password=0932227756;trustservercertificate=True")
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("tblUsers").HasKey(u => u.UserID);
            modelBuilder.Entity<Student>().ToTable("tblStudents").HasKey(s => s.StudentID);
            modelBuilder.Entity<Course>().ToTable("tblCourses").HasKey(c => c.CourseID);
            modelBuilder.Entity<Instructor>().ToTable("tblInstructors").HasKey(i => i.InstructorID);
            modelBuilder.Entity<Department>().ToTable("tblDepartments").HasKey(d => d.DepartmentID);
            modelBuilder.Entity<StudentCourse>().ToTable("tblStudentCourses")
                .HasKey(sc => new { sc.StudentID, sc.CourseID });
        }
    }
}