namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustemerManager custoManager = new CustemerManager();
            ProductManager productManager = new ProductManager();
            custoManager.Add();
            custoManager.Update();

            Customer customer = new Customer();
            customer.City = "İstanbul";
            customer.FirstName = "İrem";
            customer.LastName = "Oruç";
            customer.Id= 1;

            Customer customer2 = new Customer
            {
                Id = 1, City = "İstanbul", FirstName = "Emir", LastName = "Baş"
            };

            Console.WriteLine(customer2.FirstName);
        }   

    }
}