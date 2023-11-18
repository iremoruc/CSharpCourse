﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public Course[] Courses { get; set; }
        List<Course> Courses { get; set; }
    }
}
