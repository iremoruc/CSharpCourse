namespace OOP_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Category[] categories = new[]
            {
                new Category(){Id=1, Name="Programlama"},
                new Category(){Id=2, Name="Database"},
                new Category(){Id=3, Name="Pazarlama"},
                new Category(){Id=4, Name="Finans"}
            };

            Instructor[] instructor = new[]
            {
                new Instructor(){ Id=1, Name="Engin Demiroğ"},
                new Instructor(){ Id=2, Name="Murat Yücedağ"},
                new Instructor(){ Id=3, Name="Gençay Yıldız"},
                new Instructor(){ Id=4, Name="Musab Emir"}
            };

            Course[] courses = new[]
            {
                new Course()
                {
                    Id = 2,
                    CategoryId = 1,
                    InstructorId = 4,
                    Title = "Promramlamaya Giriş",
                    Description = "Açıklama alanı",
                    ImageUrl = "",
                    Price = 0
                }
            };

            Course course1 = new Course()
            {
                Id = 1,
                CategoryId = 1,
                InstructorId = 1,
                Title = "Promramlamaya Giriş",
                Description = "Açıklama alanı",
                ImageUrl = "",
                Price = 0
            };

            
        }
    }
}