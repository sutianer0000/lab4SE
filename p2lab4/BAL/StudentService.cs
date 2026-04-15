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
    public class StudentService
    {
        private readonly StudentRepository _repo;
        public StudentService() { _repo = new StudentRepository(); }

        public List<Student> GetAll() => _repo.GetAll();
        public Student GetById(int id) => _repo.GetById(id);
        public void Add(Student s) => _repo.Add(s);
        public void Update(Student s) => _repo.Update(s);
        public void Delete(int id) => _repo.Delete(id);
    }
}