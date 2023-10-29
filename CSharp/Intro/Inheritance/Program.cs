namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kalıtım-Miras
            Person[] persons = new Person[3]
            {
                new Customer
                {
                    FirstName="İrem"
                },new Student
                {
                    FirstName="Emir"
                },new Person
                {
                    FirstName="Nur"
                }
            };
            foreach(var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }

        }
        // Bir nesneyi bir kere miras alabiliriz. Önce inheritance sonra interfaceler. interfaclerin tek başına bir anlamı yoktur.
        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        class Customer : Person
        {
            public string City { get; set; }
        }
        class Student : Person
        {
            public string City { get; set; }
        }

    }
}