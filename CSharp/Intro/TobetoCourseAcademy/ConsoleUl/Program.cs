using Business.Concretes;
using Entities.Concretes;
using System.ComponentModel;

Category category1 = new Category();
category1.Id = 1;
category1.Name = "Programlama";

Instructor[] instructors = new Instructor[]
{
    new Instructor{ Id = 1, Name ="Engin Demiroğ"},
    new Instructor{ Id = 2, Name ="Halit Enes Kalaycı"}
};

Course[] courses = new Course[]
{
    new Course()
    {
        Id= 1,
        CategoryId= 1,
        InstructorId= 1,
        Name = "Yazılım Geliştici Yetiştirme Kampı (JavaScript)",
        Description = "1,5 ay sürecek Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız.",
        Price= 1000,
        ImageUrl= "https://process.fs.teachablecdn.com/ADNupMnWyR7kCW…www.filepicker.io/api/file/Zk7d1MdoSJ6cEShVbfd0//",
        Category = category1,
        Instructor = instructors[0]
    },
    new Course()
    {
        Id = 2,
        CategoryId = 1,
        Name = "(2023) Yazılım Geliştirici Yetiştirme Kampı - Python & Selenium",
        Description = "Python & Selenium Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız.",
        Price = 0,
        InstructorId= 2,
        Category = category1,
        Instructor = instructors[1],
    }
};

foreach(var course in courses)
{
    Console.WriteLine(course.Id);
    Console.WriteLine(course.Category.Name);
    Console.WriteLine(course.Instructor.Name);
    Console.WriteLine(course.Name);
    Console.WriteLine(course.Price);
    Console.WriteLine(course.Description);
    Console.WriteLine("-----------------------");
}


//Sıfırdan Proje oluşturunuz.
// Product sınıfını katmanlarda işletiniz
// product --> Id,Name,Unit price.