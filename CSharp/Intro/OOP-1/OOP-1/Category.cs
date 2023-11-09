using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    public class Category
    {
        public int Id { get; set; } //primary key
        public List<Course>? Courses { get; set; } // bir kategori birden fazla kur allabilir
        public string? Name { get; set; } //null geçilebilir
    }
}
