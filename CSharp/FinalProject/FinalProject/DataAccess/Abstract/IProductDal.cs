using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    //product ile ilgili veri tabanında yapacağım operasyonları içerren interface / sil ekle gibi crud işlemleri 
    public interface IProductDal : IEntityRepository<Product> // code refactoring
    {
        List<ProductDetailDto> GetProductDetails();

    }
}
