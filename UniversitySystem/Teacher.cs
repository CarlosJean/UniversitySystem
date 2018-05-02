using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystem
{
    public class Teacher
    {
        public int TeacherId { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        [NotMapped]
        public string FullName { get { return Name+" "+LastName; } }

        public virtual ICollection<Subject> Subjects { get; set; }

    }
}
