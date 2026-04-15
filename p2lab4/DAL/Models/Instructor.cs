using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Instructor
    {
        public int InstructorID { get; set; }
        public string InstructorName { get; set; }
        public int DepartmentID { get; set; }
    }
}
