﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        IDataResult<Product> GetAllByCategoryId(int id);
        IDataResult<Product> GetByUnitPrice(decimal min,decimal max);
        IDataResult<ProductDetailDto> GetProductDetails();
        IDataResult<Product> GetById(int productId);
        IResult Add(Product product); //bu kodlar istek

        //restfull mimarileri internet protokolü Http yi kullanarak gerçekleştiriyoruz.


        //RESTFUL --> HTTP --> 

    }
}
