using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    //product ile ilgili veri tabanında yapacağım operasyonları içerren interface / sil ekle gibi crud işlemleri 
    public interface IProductDal : IEntityRepository<Product>
    {
        

    }
}
