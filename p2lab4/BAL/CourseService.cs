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
    public class CourseService
    {
        private readonly CourseRepository _repo;
        public CourseService() { _repo = new CourseRepository(); }

        public List<Course> GetAll() => _repo.GetAll();
        public Course GetById(int id) => _repo.GetById(id);
        public void Add(Course c) => _repo.Add(c);
        public void Update(Course c) => _repo.Update(c);
        public void Delete(int id) => _repo.Delete(id);
    }
}