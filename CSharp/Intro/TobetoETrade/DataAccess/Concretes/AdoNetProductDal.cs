using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class AdoNetProductDal
    {
        public void Add(Product product)
        {
            Console.WriteLine("Ürün eklendi.");
        }
        public void Delete(Product product)
        {
            Console.WriteLine("Ürün silindi.");
        }

    }
}
