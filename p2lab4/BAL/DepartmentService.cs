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
    public class DepartmentService
    {
        private readonly DepartmentRepository _repo;
        public DepartmentService() { _repo = new DepartmentRepository(); }

        public List<Department> GetAll() => _repo.GetAll();
        public Department GetById(int id) => _repo.GetById(id);
        public void Add(Department d) => _repo.Add(d);
        public void Update(Department d) => _repo.Update(d);
        public void Delete(int id) => _repo.Delete(id);
    }
}