﻿using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Requests
{
    public class UpdateCourseRequest
    {
        public Guid Id { get; set; }
        public Guid CategoryId { get; set; }
        public Guid InstructorId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string Url { get; set; }
    }
}