using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentEFConsole.Models
{
    class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName{ get; set; }
        public double Grade { get; set; }
        public ICollection<Course> Courses { get; set; } = new List<Course>();


    }
}
