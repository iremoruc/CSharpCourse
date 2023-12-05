using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class Context : DbContext //Vertabanı bağlantısı
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //bağlantı adresi- connection string
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-38OEJN0\SQLEXPRESS; Initial Catalog=KodlamaIoDb; 
            Integrated Security=True; TrustServerCertificate=true");
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course> Courses { get; set; }

        //ORM aracına bir reçete veriyoruz - object relational mapping
    }
}
