using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentEFConsole.Models
{
    class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Teacher Teacher { get; set; }
        public ICollection<Student> Students { get; set; } = new List<Student>();   //this creates a relation between this class and the students class(table)
    }                                                       //new list is needed because... we are adding the rows of new data to this object
}
