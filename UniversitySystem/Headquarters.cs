using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystem
{
    public class Headquarters
    {
        public int HeadquartersId { get; set; }
        
        public string Name { get; set; }

        public string Address { get; set; }

        public long Phone { get; set; }

        public virtual List<Student> Students { get; set; }
    }
}
