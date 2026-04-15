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
    public class InstructorService
    {
        private readonly InstructorRepository _repo;
        public InstructorService() { _repo = new InstructorRepository(); }

        public List<Instructor> GetAll() => _repo.GetAll();
        public Instructor GetById(int id) => _repo.GetById(id);
        public void Add(Instructor i) => _repo.Add(i);
        public void Update(Instructor i) => _repo.Update(i);
        public void Delete(int id) => _repo.Delete(id);
    }
}