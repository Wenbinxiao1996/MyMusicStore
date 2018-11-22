﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo.CodeFirstModels
{
  public class CourseContext:DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> courses { get; set; }

        public DbSet<Students> Students { get; set; }
    }
}
