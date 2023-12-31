﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Course:Entity<Guid>
    {
        public Guid CategoryId { get; set; }
        public Category? Category { get; set; }
        public Guid InstructorId { get; set; }
        public Instructor? Instructor { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string Url { get; set; }


        
    }
}
