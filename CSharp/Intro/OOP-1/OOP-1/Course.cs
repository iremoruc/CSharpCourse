using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    public class Course //tablo
    {
        public int Id { get; set; } //primary
        public int CategoryId { get; set; } //kategorinin foreign keyi yani bir kurs bir kategoriye sahiptir.
        public int InstructorId { get; set; } // instructor foreign key. yni bir kursun bir eğitmeni vardır


        public string? Title { get; set; }
        public string? Description { get; set; }
        public int Price { get; set; }
        public string ImageUrl { get; set; }
        //public Category Category { get; set; }
        //public Instructor Instructor { get; set; }
    }
}
