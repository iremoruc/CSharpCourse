using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            //oracle,sql server,posrgres,mongodb
            _products = new List<Product>() { 
                new Product{ProductId=1,CategoryId =1, ProductName="Bardak", UnitInStock=15, UnitPrice=15},
                new Product{ProductId=2,CategoryId =1, ProductName="Kamera", UnitInStock=3, UnitPrice=500},
                new Product{ProductId=3,CategoryId =2, ProductName="Telefon", UnitInStock=2, UnitPrice=1500},
                new Product{ProductId=4,CategoryId =2, ProductName="Klavye", UnitInStock=65, UnitPrice=150},
                new Product{ProductId=5,CategoryId =2, ProductName="Fare", UnitInStock=1, UnitPrice=185 }
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //LINQ - Language Integrated quary //sql gibi filtreleme yapıyoruz
            //Lambda
            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            //foreach (var p in _products)
            //{
            //    if(product.ProductId == p.ProductId)
            //    {
            //        productToDelete = p;
            //    }
            //}
           //yukardaki foreachin aynısını yapıyor

            _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId== categoryId).ToList(); 
            // where içindeki şarta uyan bütün elemanları yeni bir liste haline getirip döndürür
        }

        public List<Product> GettAll()
        {
            
            return _products; // veritabanını olduğu gibi döndürüyoruz
        }

        public List<Product> GettAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            //Gönderdiğim ürün idsine sahip olan listedeki ürünü bul
            Product productToUpdate= _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitInStock = product.UnitInStock;
        }
    }
}
