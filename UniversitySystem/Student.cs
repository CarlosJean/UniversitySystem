using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystem
{
    public class Student
    {
        public int StudentID { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public virtual Headquarters Headquarter { get; set; }

        public virtual List<Subject> Subjects { get; set; }

    }
}
