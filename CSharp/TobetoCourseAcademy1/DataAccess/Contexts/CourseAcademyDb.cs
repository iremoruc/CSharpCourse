﻿using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Contexts
{
    public class CourseAcademyDb:DbContext
    {
        protected IConfiguration Configuration { get; set; }
        public DbSet<Category> Categories { get; set; }

        public CourseAcademyDb(DbContextOptions dbContextOptions, IConfiguration configuration): base(dbContextOptions)
        {
            Configuration= configuration;
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
