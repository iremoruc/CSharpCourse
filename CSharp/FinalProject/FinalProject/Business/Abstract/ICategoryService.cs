using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICategoryService //Kategori ile ilgili dış dünyaya servis etmek istediklerimizi buraya yazıyoruz
    {
        List<Category> GetAll();
        Category GetById(int caregoryId);

    }
}
