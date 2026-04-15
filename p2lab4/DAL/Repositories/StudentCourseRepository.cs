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
    public class StudentCourseRepository
    {
        private readonly SchoolDbContext _context;
        public StudentCourseRepository() { _context = new SchoolDbContext(); }

        public List<StudentCourse> GetByCourse(int courseId) =>
            _context.StudentCourses.Where(sc => sc.CourseID == courseId).ToList();

        public void Add(StudentCourse sc)
        {
            _context.StudentCourses.Add(sc);
            _context.SaveChanges();
        }

        public void Update(int studentId, int newCourseId)
        {
            var existing = _context.StudentCourses.FirstOrDefault(sc => sc.StudentID == studentId);
            if (existing != null)
            {
                _context.StudentCourses.Remove(existing);
                _context.StudentCourses.Add(new StudentCourse { StudentID = studentId, CourseID = newCourseId });
                _context.SaveChanges();
            }
        }

        public void Delete(int studentId)
        {
            var sc = _context.StudentCourses.FirstOrDefault(s => s.StudentID == studentId);
            if (sc != null)
            {
                _context.StudentCourses.Remove(sc);
                _context.SaveChanges();
            }
        }
    }
}