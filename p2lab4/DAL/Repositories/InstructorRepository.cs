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
    public class InstructorRepository
    {
        private readonly SchoolDbContext _context;
        public InstructorRepository() { _context = new SchoolDbContext(); }

        public List<Instructor> GetAll() => _context.Instructors.ToList();
        public Instructor GetById(int id) => _context.Instructors.FirstOrDefault(i => i.InstructorID == id);

        public void Add(Instructor instructor)
        {
            _context.Instructors.Add(instructor);
            _context.SaveChanges();
        }

        public void Update(Instructor instructor)
        {
            var existing = _context.Instructors.FirstOrDefault(i => i.InstructorID == instructor.InstructorID);
            if (existing != null)
            {
                existing.InstructorName = instructor.InstructorName;
                existing.DepartmentID = instructor.DepartmentID;
                _context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var instructor = _context.Instructors.FirstOrDefault(i => i.InstructorID == id);
            if (instructor != null)
            {
                _context.Instructors.Remove(instructor);
                _context.SaveChanges();
            }
        }
    }
}