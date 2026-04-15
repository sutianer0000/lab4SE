using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL.Models;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repositories
{
    public class CourseRepository
    {
        private readonly SchoolDbContext _context;
        public CourseRepository() { _context = new SchoolDbContext(); }

        public List<Course> GetAll() => _context.Courses.ToList();
        public Course GetById(int id) => _context.Courses.FirstOrDefault(c => c.CourseID == id);

        public void Add(Course course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();
        }

        public void Update(Course course)
        {
            var existing = _context.Courses.FirstOrDefault(c => c.CourseID == course.CourseID);
            if (existing != null)
            {
                existing.CourseName = course.CourseName;
                existing.Credits = course.Credits;
                existing.DepartmentID = course.DepartmentID;
                existing.InstructorID = course.InstructorID;
                _context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var course = _context.Courses.FirstOrDefault(c => c.CourseID == id);
            if (course != null)
            {
                _context.Courses.Remove(course);
                _context.SaveChanges();
            }
        }
    }
}