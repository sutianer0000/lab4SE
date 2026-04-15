using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL.Models;
using DAL.Repositories;
using System.Collections.Generic;

namespace BAL
{
    public class StudentCourseService
    {
        private readonly StudentCourseRepository _repo;
        public StudentCourseService() { _repo = new StudentCourseRepository(); }

        public List<StudentCourse> GetByCourse(int courseId) => _repo.GetByCourse(courseId);
        public void Add(StudentCourse sc) => _repo.Add(sc);
        public void Update(int studentId, int newCourseId) => _repo.Update(studentId, newCourseId);
        public void Delete(int studentId) => _repo.Delete(studentId);
    }
}