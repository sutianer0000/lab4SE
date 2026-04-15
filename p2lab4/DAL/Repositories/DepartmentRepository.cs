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
    public class DepartmentRepository
    {
        private readonly SchoolDbContext _context;
        public DepartmentRepository() { _context = new SchoolDbContext(); }

        public List<Department> GetAll() => _context.Departments.ToList();
        public Department GetById(int id) => _context.Departments.FirstOrDefault(d => d.DepartmentID == id);

        public void Add(Department department)
        {
            _context.Departments.Add(department);
            _context.SaveChanges();
        }

        public void Update(Department department)
        {
            var existing = _context.Departments.FirstOrDefault(d => d.DepartmentID == department.DepartmentID);
            if (existing != null)
            {
                existing.DepartmentName = department.DepartmentName;
                _context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var department = _context.Departments.FirstOrDefault(d => d.DepartmentID == id);
            if (department != null)
            {
                _context.Departments.Remove(department);
                _context.SaveChanges();
            }
        }
    }
}
