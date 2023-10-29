namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PersonManager personManager= new PersonManager();
            //personManager.Add(new Customer { Id=1, FirstName="İrem", LastName="Oruç", Address="İstanbul"});

            //Student student = new Student()
            //{
            //    Id = 1,
            //    FirstName = "Emir",
            //    LastName = "Baş",
            //    Departmant = "Computer Sciences"
            //};
            //personManager.Add(student);

            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
                new MySqlCustomerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

        }

        interface IPerson
        {
            int Id { get; set; }
            string FirstName{ get; set; }
            string LastName { get; set; }
        }

        class Customer : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Address { get; set; }
        }
        class Student : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Departmant { get; set; }

        }
        class PersonManager
        {
            public void Add(IPerson person) // bir nesne de parametre olabilir
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }
}