using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    public class Instructor // tablo oluşturduk
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<Course>? Courses { get; set; } //nir eğitmenin birden fazla kursu olabilir.
        public List<Course>? Courses { get; set; } //nir eğitmenin birden fazla kursu olabilir.
    }
}
