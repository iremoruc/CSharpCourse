using DataAccess.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class ProductManager
    {
        public void Add(Product product)
        {
            AdoNetProductDal adoNetProductDal = new AdoNetProductDal();
            adoNetProductDal.Add(product);
            //adoNetProductDal.Delete(product);
        }
    }
}
