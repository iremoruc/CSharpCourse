﻿using DataAccess.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class InstructorManager
    {
        AdoNetInstructorDal adoNetInstructorDal=new AdoNetInstructorDal();
        public void Add(Instructor instructor)
        {
            adoNetInstructorDal.Add(instructor);
        }
    }
}
