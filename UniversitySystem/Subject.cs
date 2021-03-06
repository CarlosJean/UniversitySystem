﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystem
{
    public class Subject
    {
        public int SubjectID { get; set; }

        public string Name { get; set; }

        public string Schedule { get; set; }
        
        public virtual Teacher Teacher { get; set; }

        public virtual List<Student> Students { get; set; }
    }
}
